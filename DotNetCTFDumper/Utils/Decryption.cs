﻿using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DotNetCTFDumper.Utils
{
    class Decryption
    {
        public static byte[] DecryptionKey;
        public static byte MagicChar = 54;

        public static void MakeKey(string sTitle, string sCopyright, string sProject)
        {
            var rawKey = "";
            rawKey += sTitle;
            rawKey += sCopyright;
            rawKey += sProject;
            Logger.Log("Combined data " + rawKey, true, ConsoleColor.Yellow);
            var rawKeyPtr = Marshal.StringToHGlobalAnsi(rawKey);

            var ptr = Decryption.make_key_combined(rawKeyPtr, MagicChar);

            byte[] key = new byte[256];
            Marshal.Copy(ptr, key, 0, 256);
            Marshal.FreeHGlobal(rawKeyPtr);

            DecryptionKey = key;
            Logger.Log($"First 16-Bytes of key: {DecryptionKey.GetHex(16)}", true, ConsoleColor.Yellow);
            File.WriteAllBytes($"{Settings.DumpPath}\\key.bin", DecryptionKey);
        }

        public static byte[] MakeKeyFromBytes(string data, byte magicChar = 54)
        {
            var rawKeyPtr = Marshal.StringToHGlobalAnsi(data);
            //var bytes = Encoding.UTF8.GetBytes(data);
            //var rawKeyPtr = Marshal.AllocHGlobal(bytes.Length);
            //Marshal.Copy(bytes,0,rawKeyPtr,bytes.Length);
            var ptr = Decryption.make_key_combined(rawKeyPtr, magicChar);

            byte[] key = new byte[256];
            Marshal.Copy(ptr, key, 0, 256);
            Marshal.FreeHGlobal(rawKeyPtr);
            Array.Resize(ref key,data.Length);
            Array.Resize(ref key,256);

            return key;
        }


        public static byte[] DecodeMode3(byte[] chunkData, int chunkSize, int chunkId, out int decompressed)
        {
            ByteReader reader = new ByteReader(chunkData);
            uint decompressedSize = reader.ReadUInt32();

            byte[] rawData = reader.ReadBytes((int) reader.Size());
            if ((chunkId & 1) == 1&&Settings.Build>284)
            {
                rawData[0] ^= (byte) ((byte) (chunkId & 0xFF) ^ (byte) (chunkId >> 0x8));
            }

            rawData = DecodeChunk(rawData, chunkSize);
            using (ByteReader data = new ByteReader(rawData))
            {
                uint compressedSize = data.ReadUInt32();
                decompressed = (int) decompressedSize;
                return Decompressor.decompress_block(data, (int) compressedSize, (int) decompressedSize);
            }
        }

        public static byte[] DecodeChunk(byte[] chunkData, int chunkSize)
        {
            IntPtr inputChunkPtr = Marshal.AllocHGlobal(chunkData.Length);
            Marshal.Copy(chunkData, 0, inputChunkPtr, chunkData.Length);

            IntPtr keyPtr = Marshal.AllocHGlobal(DecryptionKey.Length);
            Marshal.Copy(DecryptionKey, 0, keyPtr, DecryptionKey.Length);

            var outputChunkPtr = decode_chunk(inputChunkPtr, chunkSize, MagicChar, keyPtr);

            byte[] decodedChunk = new byte[chunkSize];
            Marshal.Copy(outputChunkPtr, decodedChunk, 0, chunkSize);

            Marshal.FreeHGlobal(inputChunkPtr);
            Marshal.FreeHGlobal(keyPtr);

            return decodedChunk;
        }


        [DllImport("Decrypter-x64.dll", EntryPoint = "decode_chunk", CharSet = CharSet.Auto)]
        public static extern IntPtr decode_chunk(IntPtr chunkData, int chunkSize, byte magicChar, IntPtr wrapperKey);

        [DllImport("Decrypter-x64.dll", EntryPoint = "make_key", CharSet = CharSet.Auto)]
        public static extern IntPtr make_key(IntPtr cTitle, IntPtr cCopyright, IntPtr cProject, byte magicChar);

        [DllImport("Decrypter-x64.dll", EntryPoint = "make_key_combined", CharSet = CharSet.Auto)]
        public static extern IntPtr make_key_combined(IntPtr data, byte magicChar);

        [DllImport("Decrypter-x64.dll", EntryPoint = "make_key_w_combined", CharSet = CharSet.Auto)]
        public static extern IntPtr make_key_w_combined(IntPtr data, byte magicChar);
    }
}
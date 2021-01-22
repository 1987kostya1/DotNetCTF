﻿using System;
using System.IO;
using System.IO.Compression;
using Joveler.Compression.ZLib;
using DeflateStream = System.IO.Compression.DeflateStream;
using GZipStream = Joveler.Compression.ZLib.GZipStream;

namespace CTFAK.Utils
{
    public static class Decompressor
    {
        public static byte[] Decompress(ByteReader exeReader, out int decompressed)
        {
            Int32 decompSize = exeReader.ReadInt32();
            Int32 compSize = exeReader.ReadInt32();
            decompressed = decompSize;
            return decompress_block(exeReader, compSize, decompSize);
        }

        public static ByteReader DecompressAsReader(ByteReader exeReader, out int decompressed)
        {
            
            return new ByteReader(Decompress(exeReader, out decompressed));
        }

        public static byte[] decompress_block(ByteReader reader, int size, int decompSize)
        {
            ZLibDecompressOptions decompOpts = new ZLibDecompressOptions();
            MemoryStream compressedStream = new MemoryStream(reader.ReadBytes(size));
            MemoryStream decompressedStream = new MemoryStream();
            using (ZLibStream zs = new ZLibStream(compressedStream, decompOpts))
            {
                zs.CopyTo(decompressedStream);
            }

            byte[] decompressedData = decompressedStream.GetBuffer();
            // Trimming array to decompSize,
            // because ZlibStream always pads to 0x100
            Array.Resize<byte>(ref decompressedData, decompSize);
            return decompressedData;
        }

        public static byte[] decompressOld(ByteReader reader, int size, int decompSize)
        {
            ZLibDecompressOptions decompOpts = new ZLibDecompressOptions();
            MemoryStream compressedStream = new MemoryStream(reader.ReadBytes(size));
            MemoryStream decompressedStream = new MemoryStream();

            byte[] decompressedData = decompressedStream.GetBuffer();
            // Trimming array to decompSize,
            // because ZlibStream always pads to 0x100
            Array.Resize<byte>(ref decompressedData, decompSize);
            return decompressedData;
        }
        

        public static byte[] compress_block(byte[] data)
        {
            ZLibCompressOptions compOpts = new ZLibCompressOptions();
            compOpts.Level = ZLibCompLevel.Default;
            MemoryStream decompressedStream = new MemoryStream(data);
            MemoryStream compressedStream = new MemoryStream();
            byte[] compressedData = null;
            ZLibStream zs = new ZLibStream(compressedStream, compOpts);
            decompressedStream.CopyTo(zs);
            zs.Close();

            compressedData = compressedStream.GetBuffer();
            Array.Resize<byte>(ref compressedData, (int) zs.TotalOut);

            return compressedData;
        }
    }
}
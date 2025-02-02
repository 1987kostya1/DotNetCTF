﻿using System;
using System.Collections.Generic;
using System.IO;
using CTFAK.GUI;
using CTFAK.Utils;
using static CTFAK.MMFParser.EXE.ChunkList;

namespace CTFAK.MMFParser.EXE.Loaders.Banks
{
    public class MusicBank : ChunkLoader
    {
        public int NumOfItems = 0;
        public int References = 0;
        public List<MusicFile> Items;

        public override void Write(ByteWriter Writer)
        {
            throw new NotImplementedException();
        }

        public override string[] GetReadableData()
        {
            throw new NotImplementedException();
        }
        public void Read(bool save)
        {
            var cache = Settings.DumpMusic;
            Settings.DumpMusic = save;
            Read();
            Settings.DumpMusic = cache;
        }
        public event MainForm.SaveHandler OnMusicSaved;
        public override void Read()
        {

            if (!Settings.DoMFA)Reader.Seek(0);//Reset the reader to avoid bugs when dumping more than once
            Items = new List<MusicFile>();
            // if (!Settings.DoMFA)return;
            NumOfItems = Reader.ReadInt32();
            if (!Settings.DumpMusic) return;
            Console.WriteLine(NumOfItems);
            for (int i = 0; i < NumOfItems; i++)
            {
                if (MainForm.BreakMusics) break;
                var item = new MusicFile(Reader);
                item.Read();
                OnMusicSaved?.Invoke(i,(int) NumOfItems);
                Items.Add(item);
            }
        }

        public MusicBank(ByteReader reader) : base(reader)
        {
        }

        
    }

    public class MusicFile : ChunkLoader
    {
        
        public int Checksum;
        public int References;
        public string Name;
        private uint _flags;
        public byte[] Data;
        public int Handle;

        public override void Write(ByteWriter Writer)
        {
            throw new NotImplementedException();
        }

        public override string[] GetReadableData()
        {
            throw new NotImplementedException();
        }

        
        public override void Read()
        {
            var compressed = true;
            Handle = Reader.ReadInt32();
            if (compressed)
            {
                Reader = Decompressor.DecompressAsReader(Reader,out int decompressed);
            }

            Checksum = Reader.ReadInt32();
            References = Reader.ReadInt32();
            var size = Reader.ReadUInt32();
            _flags = Reader.ReadUInt32();
            var reserved = Reader.ReadInt32();
            var nameLen = Reader.ReadInt32();
            Name = Reader.ReadWideString(nameLen);
            Data = Reader.ReadBytes((int) (size - nameLen));
            if (Settings.DumpMusic)
            {
                Logger.Log("Saving MIDI: "+Name);
                Save($"{Settings.MusicPath}\\{Helper.CleanInput(Name)}.MID");
            }
        }

        public void Save(string filename)
        {
            File.WriteAllBytes(filename,Data);
        }

        public MusicFile(ByteReader reader) : base(reader)
        {
        }

        
    }

   
}
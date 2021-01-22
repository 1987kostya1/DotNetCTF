﻿using CTFAK.Utils;

namespace CTFAK.MMFParser.EXE.Loaders.Events.Parameters
{
    public class GroupPointer:ParameterCommon
    {
        public int Pointer;
        public short Id;

        public GroupPointer(ByteReader reader) : base(reader)
        {
        }

        public override void Read()
        {
            Pointer = Reader.ReadInt32();
            Id = Reader.ReadInt16();
            
        }

        public override void Write(ByteWriter Writer)
        {
            Writer.WriteInt32(Pointer);
            Writer.WriteInt32(Id);
        }
    }
}
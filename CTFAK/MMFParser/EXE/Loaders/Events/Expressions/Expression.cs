﻿using System;
using CTFAK.Utils;

namespace CTFAK.MMFParser.EXE.Loaders.Events.Expressions
{
    class Expression : DataLoader
    {
        public Constants.ObjectType ObjectType;
        public int Num;
        public int ObjectInfo;
        public int ObjectInfoList;
        public Expression(ByteReader reader) : base(reader) { }
        public override void Write(ByteWriter Writer)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            
        }
    }
}

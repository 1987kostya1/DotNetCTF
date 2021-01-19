﻿using CTFAK.Utils;

namespace CTFAK.MMFParser.EXE.Loaders.Events.Parameters
{
    class Time : ParameterCommon
    {
        public int Timer;
        public int Loops;

        public Time(ByteReader reader) : base(reader) { }
        public override void Read()
        {
            Timer = Reader.ReadInt32();
            Loops = Reader.ReadInt32();
            
        }

        public override void Write(ByteWriter Writer)
        {
            Writer.WriteInt32(Timer);
            Writer.WriteInt32(Loops);
        }

        public override string ToString()
        {

            return $"Time time: {Timer} loops: {Loops}";
        }
    }
}

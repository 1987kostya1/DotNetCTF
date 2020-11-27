﻿using mmfparser;
using NetMFAPatcher.chunkloaders;
using NetMFAPatcher.MMFParser.Data;
using NetMFAPatcher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NetMFAPatcher.mmfparser.Constants;

namespace NetMFAPatcher.MMFParser.ChunkLoaders.Events
{
    public class Condition : DataLoader
    {
        public int Flags;
        public int OtherFlags;
        public int DefType;
        public int NumberOfParameters;
        public ObjectType ObjectType;
        public int num;
        public int ObjectInfo;
        public int Identifier;
        public int ObjectInfoList;
        public List<Parameter> items = new List<Parameter>();
        public Condition(ByteIO reader) : base(reader) { }
        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            var currentPosition = reader.Tell();
            var size = reader.ReadUInt16();
            ObjectType = (ObjectType)reader.ReadInt16();
            num = reader.ReadInt16();
            ObjectInfo = reader.ReadUInt16();
            ObjectInfoList = reader.ReadInt16();
            Flags = reader.ReadSByte();
            OtherFlags = reader.ReadSByte();
            NumberOfParameters = reader.ReadByte();
            DefType = reader.ReadByte();
            Identifier = reader.ReadInt16();
            for (int i = 0; i < NumberOfParameters; i++)
            {
                var item = new Parameter(reader);
                item.Read();
                items.Add(item);
            }
            reader.Seek(currentPosition + size);
            

            
        }
        public override string ToString()
        {
            return $"Condition {ObjectType}-{num}-{(items.Count > 0 ? items[0].ToString() : "cock")}";

        }
    }

    public class Action : DataLoader
    {
        public int Flags;
        public int OtherFlags;
        public int DefType;
        public ObjectType ObjectType;
        public int num;
        public int ObjectInfo;
        public int ObjectInfoList;
        public List<Parameter> items = new List<Parameter>();
        public Action(ByteIO reader) : base(reader) { }
        public override void Print( )
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            var currentPosition = reader.Tell();
            var size = reader.ReadUInt16();
            ObjectType = (ObjectType)reader.ReadInt16();
            num = reader.ReadInt16();
            ObjectInfo = reader.ReadUInt16();
            ObjectInfoList = reader.ReadInt16();
            Flags = reader.ReadSByte();
            OtherFlags = reader.ReadSByte();
            var number_of_parameters=reader.ReadByte();
            DefType = reader.ReadByte();
            for (int i = 0; i < DefType; i++)
            {
                var item = new Parameter(reader);
                item.Read();
                items.Add(item);
            }


        }
        public override string ToString()
        {
            
            return $"Action {ObjectType}-{num}-{(items.Count>0?items[0].ToString():"cock")}";

        }
    }

    public class Parameter : DataLoader
    {
        public int Code;
        public DataLoader loader;

        public Parameter(ByteIO reader) : base(reader) { }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            var current_position = reader.Tell();
            var size = reader.ReadInt16();
            Code = reader.ReadInt16();


            var ActualLoader = Helper.LoadParameter(Code,reader);
            this.loader = ActualLoader;
            if (loader!=null)
            {
                
                loader.Read();
            }
            else
            {
                //throw new Exception("Loader is null");
            }
            reader.Seek(current_position+size);

        }
        public object value
        {
            get
            {
                if (loader != null)
                {


                    if (loader.GetType().GetField("value") != null)
                    {
                        return loader.GetType().GetField("value").GetValue(loader);
                    }
                    else
                    {
                        return null;
                    }
                }
                else return null;
            }
        }
        public override string ToString()
        {
            if (loader != null) return loader.ToString();
            else return "UNK-PARAMETER";

        }
    }

}

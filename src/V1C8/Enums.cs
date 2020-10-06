using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    public class Enums:IDisposable
    {
        private V1C8COMConnector owner;
        protected Enums()
        {
                
        }
        public Enums(V1C8COMConnector v1C8COMConnector)
        {
            owner = v1C8COMConnector;
        }
        public int Count { get => owner.COMObject.Metadata.Enums.Count(); }
        public EnumMetaData Get(int i) => new EnumMetaData(owner.COMObject.Metadata.Enums.Get(i));

        public void Dispose()
        {
            owner = null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Metadata
{
    public class EnumsMetaData:V1C8COMObject
    {
        public EnumsMetaData(MetaData owner, object handle):base(owner,handle)
        {
            
        }
        public int Count { get => MethodInt("Count"); }
        public EnumMetaData Get(int i)=>Method<EnumMetaData>("Get",i);
 
    }
}
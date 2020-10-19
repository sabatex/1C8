using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class EnumMetaData:MetaDataBase
    {
        public EnumMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public EnumValues EnumValues{get=>GetProperty<EnumValues>("EnumValues");}
 
    }
}
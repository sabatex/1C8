using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8
{
    public class EnumMetaData:V1C8COMObject
    {
        public EnumMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string Name {get=>GetPropertyString("Name");}
        public string Synonym {get=>GetPropertyString("Synonym");}
        public  string Comment {get=>GetPropertyString("Comment");}

        public EnumValues EnumValues{get=>GetProperty<EnumValues>("EnumValues");}
 
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class MetaDataBase:V1C8COMObject
    {
        public MetaDataBase(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string Name {get=>GetPropertyString("Name");}
        public string Synonym {get=>GetPropertyString("Synonym");}
        public  string Comment {get=>GetPropertyString("Comment");}
    }
}
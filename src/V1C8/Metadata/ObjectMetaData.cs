using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class ObjectMetaData:MetaDataBase
    {
        public ObjectMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string FullName()=>MethodString("FullName");
     }
   
}
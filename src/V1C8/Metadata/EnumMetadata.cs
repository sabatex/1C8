using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class EnumMetaData:ObjectMetaData
    {
        public EnumMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public MetadataObjectCollection<EnumItemMetaData>  EnumValues{get=>GetProperty<MetadataObjectCollection<EnumItemMetaData>>("EnumValues");}
 
    }
}
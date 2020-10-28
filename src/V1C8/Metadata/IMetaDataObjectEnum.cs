using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectEnum:IV1C8Description
    {
        public IMetaDataObjectCollection<IMetaDataObjectEnumValue>  EnumValues{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectEnumValue>>("EnumValues");}
 
    }
}
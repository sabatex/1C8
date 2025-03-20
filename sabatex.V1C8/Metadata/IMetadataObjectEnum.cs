using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectEnum:IMetadataObject
    {
        public MetadataObjectCollection<IMetadataObjectEnumValue>  EnumValues => new MetadataObjectCollection<IMetadataObjectEnumValue>(GetProperty<ICOMObject1C8>("EnumValues"));
    }
}
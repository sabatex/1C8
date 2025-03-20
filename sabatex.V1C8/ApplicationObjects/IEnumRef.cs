using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IEnumRef : ICOMObject1C8
    {
        public IMetadataObjectEnumValue Metadata() => Method<IMetadataObjectEnumValue>("Metadata");
        public bool IsEmpty => Method<bool>("IsEmpty");
        public string ValueName
        {
            get 
            {
                var name = Metadata().Name;
                var index = GlobalContext.Enums[name].IndexOf(this);
                return GlobalContext.MetaData.Enums[name].EnumValues[index].Name;
            }
        }
 
    }
}

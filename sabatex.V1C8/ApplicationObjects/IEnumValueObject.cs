using Sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.ApplicationObjects
{
    public interface IEnumValueObject:ICOMObject1C8
    {
        public IMetadataObjectEnumValue  Metadata() => Method<IMetadataObjectEnumValue>("Metadata");
        public bool IsEmpty() => Method<bool>("IsEmpty");
    }
}

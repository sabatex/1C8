using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IEnumRef:ICOMObject1C8
    {
        public IMetadataObjectEnumValue Metadata() => Method<IMetadataObjectEnumValue>("Metadata");
        public bool IsEmpty => Method<bool>("IsEmpty");
    }
}

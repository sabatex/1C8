using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogRef:ICOMObject1C8
    {
        public Guid UUID
        {
            get
            {
                var uuid = Method<ICOMObject1C8>("UUID");
                return Guid.Parse(GlobalContext.String(uuid));
            }
        }

        public IMetadataObjectCatalog Metadata() => Method<IMetadataObjectCatalog>("Metadata");

    }
}

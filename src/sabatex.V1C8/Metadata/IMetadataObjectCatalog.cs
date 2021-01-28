using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectCatalog:IMetadataObject,IMetadataAttributes,IMetadataObjectTabularSections
    {
        IFixedArray GetPredefinedNames() => Method<IFixedArray>("GetPredefinedNames");
        MetadataObjectCollection<IMetadataStandardAttributeDescription> StandardAttributes => new MetadataObjectCollection<IMetadataStandardAttributeDescription>(GetProperty<ICOMObject1C8>("StandardAttributes"));

    }
}
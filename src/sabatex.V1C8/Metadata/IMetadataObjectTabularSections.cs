using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectTabularSections:IMetadataObject,IMetadataAttributes
    {
        MetadataObjectCollection<IMetadataObjectTabularSection> TabularSections => new MetadataObjectCollection<IMetadataObjectTabularSection>(GetProperty<ICOMObject1C8>("TabularSections"));
    }
}
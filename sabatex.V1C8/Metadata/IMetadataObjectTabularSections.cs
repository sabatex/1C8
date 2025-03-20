using System;
using System.Collections.Generic;
using System.Text;


namespace Sabatex.V1C8.Metadata;

public interface IMetadataObjectTabularSections : IMetadataObject, IMetadataAttributes
{
    IMetadataObjectCollection<IMetadataObjectTabularSection> TabularSections=> GetProperty<ICOMObject1C8>("TabularSections") as IMetadataObjectCollection<IMetadataObjectTabularSection>;
}
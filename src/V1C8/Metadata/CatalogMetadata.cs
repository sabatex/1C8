using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class CatalogMetaData:ObjectMetaData
    {
        public CatalogMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
 
        public MetadataObjectCollection<FieldMetadata> Attributes{get=>GetProperty<MetadataObjectCollection<FieldMetadata>>("Attributes");}
        public MetadataObjectCollection<CatalogTableMetaData> TabularSections{get=>GetProperty<MetadataObjectCollection<CatalogTableMetaData>>("TabularSections");}
 
    }
}
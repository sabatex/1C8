using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class DocumentMetaData:ObjectMetaData
    {
        public DocumentMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
 
        public MetadataObjectCollection<FieldMetadata> Attributes{get=>GetProperty<MetadataObjectCollection<FieldMetadata>>("Attributes");}
        public MetadataObjectCollection<DocumentTableMetaData> TabularSections{get=>GetProperty<MetadataObjectCollection<DocumentTableMetaData>>("TabularSections");}
 
    }
}
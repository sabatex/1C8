using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class DocumentTableMetaData:ObjectMetaData
    {
        public DocumentTableMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public MetadataObjectCollection<FieldMetadata> Attributes{get=>GetProperty<MetadataObjectCollection<FieldMetadata>>("Attributes");}

    }
}
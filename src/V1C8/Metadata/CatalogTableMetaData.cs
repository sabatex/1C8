using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class CatalogTableMetaData:ObjectMetaData
    {
        public CatalogTableMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public EnumerationsMetadata<FieldMetadata> Attributes{get=>GetProperty<EnumerationsMetadata<FieldMetadata>>("Attributes");}

    }
}
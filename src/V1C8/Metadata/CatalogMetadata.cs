using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class CatalogMetaData:MetaDataBase
    {
        public CatalogMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
 
        public EnumerationsMetadata<FieldMetadata> Attributes{get=>GetProperty<EnumerationsMetadata<FieldMetadata>>("Attributes");}
 
    }
}
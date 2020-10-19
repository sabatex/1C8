using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Metadata
{
    public class CatalogsMetaData:EnumerationsMetadata
    {
        public CatalogsMetaData(MetaData owner, object handle):base(owner,handle)
        {
            
        }
        public CatalogMetaData Get(int i)=>base.Get<CatalogMetaData>(i);
 
    }
}
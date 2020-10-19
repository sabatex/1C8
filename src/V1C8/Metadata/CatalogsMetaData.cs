using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Metadata
{
    public class CatalogsMetaData:MetaDataBase
    {
        public CatalogsMetaData(MetaData owner, object handle):base(owner,handle)
        {
            
        }
        public int Count { get => MethodInt("Count"); }
        public CatalogMetaData Get(int i)=>Method<CatalogMetaData>("Get",i);
 
    }
}
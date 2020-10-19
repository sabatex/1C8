using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class CatalogAttributesMetadata:EnumerationsMetadata
    {
        public CatalogAttributesMetadata(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public FieldMetadata Get(int i)=>base.Get<FieldMetadata>(i);

    }
}


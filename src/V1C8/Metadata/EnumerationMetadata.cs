using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class EnumerationsMetadata<T>:V1C8COMObject where T:V1C8COMObject
    {
        public EnumerationsMetadata(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Count()=>MethodSruct<int>("Count");
        public T Get(int i) =>Method<T>("Get",i);
    }
}


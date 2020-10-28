using System.Collections;
using System.Collections.Generic;

namespace sabatex.V1C8
{
    public interface IV1C8Collection<T>:IEnumerable<T>,IV1C8COMObject where T:IV1C8COMObject
    { 
        IEnumerator<T> GetEnumerator()=>new V1C8Enumerator<T>(this);
    
        IEnumerator IEnumerable.GetEnumerator()=>new V1C8Enumerator<T>(this);
    }
    
}
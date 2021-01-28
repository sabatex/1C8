using System.Collections;
using System.Collections.Generic;
namespace sabatex.V1C8
{
    public class V1C8Enumerator<T> : IEnumerator<T> where T:ICOMObject1C8
    {

        ICOMObject1C8 _context;
        int _current;
        int _count;
        public V1C8Enumerator(ICOMObject1C8 context)
        {
           _context=context; 
           _current=0;
           _count = _context.Method<int>("Count");
        }
        public T Current => _context.Method<T>("Get",_current);

        object IEnumerator.Current => _context.Method<T>("Get",_current);

        public void Dispose()
        {
            _context = null;
        }

        public bool MoveNext()
        {
             _current++;
            return _current < _count;
        }

        public void Reset()
        {
            _current=0;;
        }
    }

}
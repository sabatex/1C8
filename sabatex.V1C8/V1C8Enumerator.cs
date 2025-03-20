using System.Collections;
using System.Collections.Generic;
namespace Sabatex.V1C8
{
    public class V1C8Enumerator<T> : IEnumerator<T> where T:ICOMObject1C8
    {
        int position = -1;

        ICOMObject1C8 _context;
        int _count;
        public V1C8Enumerator(ICOMObject1C8 context)
        {
           _context=context; 
           _count = _context.Method<int>("Count");
        }
        public bool MoveNext()
        {
             position++;
            return position < _context.Method<int>("Count");
        }

        public void Reset()
        {
            position=-1;
        }

        public T Current => _context.Method<T>("Get",position);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _context = null;
        }


    }

}
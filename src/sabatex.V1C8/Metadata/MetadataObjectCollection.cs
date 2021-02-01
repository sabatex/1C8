using System.Collections;
using System.Collections.Generic;
using sabatex.V1C8;
namespace sabatex.V1C8.Metadata
{
    public class MetadataObjectCollection<T> : IEnumerable<T> where T:ICOMObject1C8
    {
        ICOMObject1C8 _collection;
        public MetadataObjectCollection(ICOMObject1C8 collection)
        {
            _collection = collection;    
        }
        public int Count() => _collection.Method<int>("Count");
        public T Get(int i) => _collection.Method<T>("Get", i);
        public int IndexOf(COMObject1C8 obj) => _collection.Method<int>("IndexOf", obj);
        public T EmptyRef() => _collection.Method<T>("EmptyRef");

        public T Find(string value) => _collection.Method<T>("Find", value);
        public bool Contains(COMObject1C8 obj) => _collection.Method<bool>("Contains", obj);

        public IEnumerator<T> GetEnumerator()
        {
            return new V1C8Enumerator<T>(_collection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new V1C8Enumerator<T>(_collection);
        }

        public T this[string index] => Find(index);
        public T this[int index] => Get(index);

    }


}
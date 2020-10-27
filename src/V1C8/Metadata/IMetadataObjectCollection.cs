using System.Collections.Generic;
using sabatex.V1C8;
namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectCollection<T> : IV1CCOMObject
    {
        int Count() => Method<int>("Count");
        T Get(int i) => Method<T>("Get", i);
        int IndexOf(V1C8COMObject obj) => Method<int>("IndexOf", obj);
        T EmptyRef() => Method<T>("EmptyRef");

        T Find(string value) => Method<T>("Find", value);
        bool Contains(V1C8COMObject obj) => Method<bool>("Contains", obj);

        T this[string index] => Find(index);
    }

}
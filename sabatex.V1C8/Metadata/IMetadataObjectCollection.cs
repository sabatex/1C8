using System.Collections;
using System.Collections.Generic;
using Sabatex.V1C8;
namespace Sabatex.V1C8.Metadata;

public interface IMetadataObjectCollection<T> :ICOMObject1C8,  IEnumerable<T> where T:ICOMObject1C8
{
    public int Count() => Method<int>("Count");
    public T Get(int i) => Method<T>("Get", i);
    public int IndexOf(COMObject1C8 obj) => Method<int>("IndexOf", obj);
    public T EmptyRef() => Method<T>("EmptyRef");

    public T Find(string value) => Method<T>("Find", value);
    public bool Contains(COMObject1C8 obj) => Method<bool>("Contains", obj);

    public T this[string index] => Find(index);
    public T this[int index] => Get(index);

}
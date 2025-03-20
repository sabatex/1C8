using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IEnumManager:ICOMObject1C8
    {
        public int IndexOf(IEnumRef enumRef) => Method<int>("IndexOf",enumRef);
        public int Count() => Method<int>("Count");
        public IEnumRef Get(int index) => Method<IEnumRef>("Get", index);
        public IEnumRef EmptyRef() => Method<IEnumRef>("EmptyRef");
        public IEnumRef this[string index] => Method<IEnumRef>("Get",index);
    }
}

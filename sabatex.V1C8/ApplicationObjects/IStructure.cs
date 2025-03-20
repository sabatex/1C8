using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatex.V1C8.ApplicationObjects
{
    public interface IStructure:ICOMObject1C8
    {
        public void Insert(string key, object value) => Method("Insert", key, value);
        public int Count() => Method<int>("Count");
        public void Clear() => Method("Clear");
        public void delete(string key) => Method("Delete",key);
        public object Get(string key) => Method<object>("Get", key);
        public void Set(string key, object value) => Method("Set", key, value);
        public object this[string key] { get => Get(key); set => Set(key, value); }

    }
}

using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8
{
    public interface IGlobalContext:ICOMObject1C8
    {
        public string String(ICOMObject1C8 value) => Method<string>("String", value);
        public Guid GetObjectId(ICOMObject1C8 value) => Guid.Parse(this.String(value.GetProperty<ICOMObject1C8>("УникальныйИдентификатор")));

        public T Eval<T>(string expression) => Method<T>("Eval", expression);
        public T NewObject<T>(string name) => Method<T>("NewObject", name);
        public IMetadataConfiguration MetaData { get => GetProperty<IMetadataConfiguration>("Metadata"); }

        //public References Справочники { get => GetProperty<References>("Справочники"); }

    }
}

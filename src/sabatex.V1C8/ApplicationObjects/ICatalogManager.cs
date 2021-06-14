using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogManager:ICOMObject1C8
    {
        public ICOMObject1C8 EmptyRef() => Method<ICOMObject1C8>("EmptyRef");
        public ICatalogRef GetRef(ICOMObject1C8 Ref) => Method<ICatalogRef>("GetRef", Ref);
        public ICatalogRef GetRef(string uuid) => GetRef(GlobalContext.NewObject<ICOMObject1C8>("UUID", uuid));
        public ICatalogSelection Select(ICOMObject1C8 parent=null, ICOMObject1C8 owner=null, ICOMObject1C8 filter=null, string order = null)
        {
            return Method<ICatalogSelection>("Select", parent, owner, filter, order);
        }

        public ICatalogRef FindByCode(string code, bool? fullCode=null,ICOMObject1C8 parent=null,ICOMObject1C8 owner=null)
        {
            var result = Method<ICatalogRef>("FindByCode", code,fullCode,parent,owner);
            if (result == null) return null;
            if (result.Equals(EmptyRef())) return null;
            return result;
        }

        public ICatalogObject CreateFolder() => Method<ICatalogObject>("CreateFolder");
        public ICatalogObject CreateItem() => Method<ICatalogObject>("CreateItem");

    }
}

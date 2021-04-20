using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IDocumentManager:ICOMObject1C8
    {
        public ICOMObject1C8 EmptyRef() => Method<ICOMObject1C8>("EmptyRef");
        public IDocumentSelection Select(DateTime? startDate, DateTime? endDate, ICOMObject1C8 filter, string order = null)
        {
            return Method<IDocumentSelection>("Select", startDate, endDate, filter, order);
        }

        public IDocumentRef FindByNumber(string numberDoc,DateTime? date = null)
        {
            var result = date == null ? Method<IDocumentRef>("FindByNumber", numberDoc) : Method<IDocumentRef>("FindByNumber", numberDoc, date);
            if (result == null) return null;
            if (result.Equals(EmptyRef())) return null;
            return result;
        }

        public IDocumentRef GetRef(ICOMObject1C8 Ref) => Method<IDocumentRef>("GetRef",Ref);
        public IDocumentRef GetRef(string uuid) => GetRef(GlobalContext.NewObject<ICOMObject1C8>("UUID", uuid));
 
    
    }
}

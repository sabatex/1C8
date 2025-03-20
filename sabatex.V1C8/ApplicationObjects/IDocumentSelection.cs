using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IDocumentSelection:ICOMObject1C8
    {
        public bool Next() => Method<bool>("Next");
        public ICOMObject1C8 GetObject() => Method<ICOMObject1C8>("GetObject");


    }
}

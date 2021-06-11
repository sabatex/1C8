using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogSelection:ICatalogRef
    {
        public bool Next() => Method<bool>("Next");
        public ICOMObject1C8 GetObject() => Method<ICOMObject1C8>("GetObject");

    }
}

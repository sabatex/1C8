using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogsManager:ICOMObject1C8
    {
        public ICatalogManager this[string index] => GetProperty<ICatalogManager>(index);
    }
}

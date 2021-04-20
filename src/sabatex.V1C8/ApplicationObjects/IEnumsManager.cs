using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IEnumsManager:ICOMObject1C8
    {
        public IEnumManager this[string index] => GetProperty<IEnumManager>(index);
    }
}

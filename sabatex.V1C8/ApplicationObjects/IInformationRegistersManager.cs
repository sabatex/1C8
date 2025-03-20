using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IInformationRegistersManager : ICOMObject1C8
    {
        public IInformationRegisterManager this[string index] => GetProperty<IInformationRegisterManager>(index);
    }
}

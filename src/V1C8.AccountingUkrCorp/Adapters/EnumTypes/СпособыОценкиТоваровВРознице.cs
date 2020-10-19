using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценкиТоваровВРознице:EnumBase
    {
        public СпособыОценкиТоваровВРознице(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоСтоимостиПриобретения => GetProperty<EnumItem>("ПоСтоимостиПриобретения");
        public EnumItem ПоПродажнойСтоимости => GetProperty<EnumItem>("ПоПродажнойСтоимости");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПриоритетыОбъектовОбмена:EnumBase
    {
        public ПриоритетыОбъектовОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПриоритетОбъектаОбменаНиже => GetProperty<EnumItem>("ПриоритетОбъектаОбменаНиже");
        public EnumItem ПриоритетОбъектаОбменаСовпадает => GetProperty<EnumItem>("ПриоритетОбъектаОбменаСовпадает");
        public EnumItem ПриоритетОбъектаОбменаВыше => GetProperty<EnumItem>("ПриоритетОбъектаОбменаВыше");
    }
}

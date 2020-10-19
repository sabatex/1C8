using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПриоритетыОбъектовОбмена:V1C8COMObject
    {
        public ПриоритетыОбъектовОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПриоритетОбъектаОбменаНиже => GetProperty<EnumItemBase>("ПриоритетОбъектаОбменаНиже");
        public EnumItemBase ПриоритетОбъектаОбменаСовпадает => GetProperty<EnumItemBase>("ПриоритетОбъектаОбменаСовпадает");
        public EnumItemBase ПриоритетОбъектаОбменаВыше => GetProperty<EnumItemBase>("ПриоритетОбъектаОбменаВыше");
    }
}

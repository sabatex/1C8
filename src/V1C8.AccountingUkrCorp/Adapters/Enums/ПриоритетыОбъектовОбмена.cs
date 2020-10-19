using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПриоритетыОбъектовОбмена:V1C8COMObject
    {
        public ПриоритетыОбъектовОбмена(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПриоритетОбъектаОбменаНиже => GetProperty<EnumItemBase>();
        public EnumItemBase ПриоритетОбъектаОбменаСовпадает => GetProperty<EnumItemBase>();
        public EnumItemBase ПриоритетОбъектаОбменаВыше => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПринятияКУчетуОсновныхСредств:V1C8COMObject
    {
        public ВидыОперацийПринятияКУчетуОсновныхСредств(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>();
        public EnumItemBase ПоРезультатамИнвентаризации => GetProperty<EnumItemBase>();
    }
}

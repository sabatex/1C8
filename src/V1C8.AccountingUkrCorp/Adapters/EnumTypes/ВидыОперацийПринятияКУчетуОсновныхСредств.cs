using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПринятияКУчетуОсновныхСредств:V1C8COMObject
    {
        public ВидыОперацийПринятияКУчетуОсновныхСредств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>("ОбъектыСтроительства");
        public EnumItemBase ПоРезультатамИнвентаризации => GetProperty<EnumItemBase>("ПоРезультатамИнвентаризации");
    }
}

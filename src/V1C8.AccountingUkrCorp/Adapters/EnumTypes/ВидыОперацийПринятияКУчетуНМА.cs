using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПринятияКУчетуНМА:V1C8COMObject
    {
        public ВидыОперацийПринятияКУчетуНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>("НематериальныеАктивы");
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>("ОбъектыСтроительства");
        public EnumItemBase ВводНачальныхОстатков => GetProperty<EnumItemBase>("ВводНачальныхОстатков");
    }
}

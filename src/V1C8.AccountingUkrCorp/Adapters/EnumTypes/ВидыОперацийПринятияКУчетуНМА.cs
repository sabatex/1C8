using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПринятияКУчетуНМА:EnumBase
    {
        public ВидыОперацийПринятияКУчетуНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НематериальныеАктивы => GetProperty<EnumItem>("НематериальныеАктивы");
        public EnumItem ОбъектыСтроительства => GetProperty<EnumItem>("ОбъектыСтроительства");
        public EnumItem ВводНачальныхОстатков => GetProperty<EnumItem>("ВводНачальныхОстатков");
    }
}

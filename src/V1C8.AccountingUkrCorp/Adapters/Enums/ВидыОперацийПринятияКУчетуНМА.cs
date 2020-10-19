using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПринятияКУчетуНМА:V1C8COMObject
    {
        public ВидыОперацийПринятияКУчетуНМА(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>();
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>();
        public EnumItemBase ВводНачальныхОстатков => GetProperty<EnumItemBase>();
    }
}

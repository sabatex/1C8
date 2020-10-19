using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийСписаниеТоваров:V1C8COMObject
    {
        public ВидыОперацийСписаниеТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТоварыПродукция => GetProperty<EnumItemBase>("ТоварыПродукция");
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
        public EnumItemBase БланкиСтрогогоУчета => GetProperty<EnumItemBase>("БланкиСтрогогоУчета");
    }
}

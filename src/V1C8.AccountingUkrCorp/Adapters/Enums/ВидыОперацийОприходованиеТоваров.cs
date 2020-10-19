using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийОприходованиеТоваров:V1C8COMObject
    {
        public ВидыОперацийОприходованиеТоваров(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТоварыПродукция => GetProperty<EnumItemBase>();
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
        public EnumItemBase БланкиСтрогогоУчета => GetProperty<EnumItemBase>();
    }
}

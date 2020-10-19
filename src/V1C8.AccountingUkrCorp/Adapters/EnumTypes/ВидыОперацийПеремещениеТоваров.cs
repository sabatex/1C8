using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПеремещениеТоваров:EnumBase
    {
        public ВидыОперацийПеремещениеТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ТоварыПродукция => GetProperty<EnumItem>("ТоварыПродукция");
        public EnumItem Оборудование => GetProperty<EnumItem>("Оборудование");
        public EnumItem БланкиСтрогогоУчета => GetProperty<EnumItem>("БланкиСтрогогоУчета");
    }
}

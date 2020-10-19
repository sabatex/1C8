using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДеятельностиДляДДС:V1C8COMObject
    {
        public ВидыДеятельностиДляДДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Операционная => GetProperty<EnumItemBase>("Операционная");
        public EnumItemBase Инвестиционная => GetProperty<EnumItemBase>("Инвестиционная");
        public EnumItemBase Финансовая => GetProperty<EnumItemBase>("Финансовая");
    }
}

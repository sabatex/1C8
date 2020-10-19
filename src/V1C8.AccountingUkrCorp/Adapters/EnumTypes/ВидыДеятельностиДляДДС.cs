using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДеятельностиДляДДС:EnumBase
    {
        public ВидыДеятельностиДляДДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Операционная => GetProperty<EnumItem>("Операционная");
        public EnumItem Инвестиционная => GetProperty<EnumItem>("Инвестиционная");
        public EnumItem Финансовая => GetProperty<EnumItem>("Финансовая");
    }
}

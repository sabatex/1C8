using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДеятельностиДляДДС:V1C8COMObject
    {
        public ВидыДеятельностиДляДДС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Операционная => GetProperty<EnumItemBase>();
        public EnumItemBase Инвестиционная => GetProperty<EnumItemBase>();
        public EnumItemBase Финансовая => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийТребованиеНакладная:V1C8COMObject
    {
        public ВидыОперацийТребованиеНакладная(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Материалы => GetProperty<EnumItemBase>("Материалы");
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
    }
}

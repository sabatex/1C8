using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийТребованиеНакладная:V1C8COMObject
    {
        public ВидыОперацийТребованиеНакладная(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Материалы => GetProperty<EnumItemBase>();
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
    }
}

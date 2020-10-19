using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийКомплектацияНоменклатуры:V1C8COMObject
    {
        public ВидыОперацийКомплектацияНоменклатуры(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Комплектация => GetProperty<EnumItemBase>();
        public EnumItemBase Разукомплектация => GetProperty<EnumItemBase>();
    }
}

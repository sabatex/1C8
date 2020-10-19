using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийКомплектацияНоменклатуры:V1C8COMObject
    {
        public ВидыОперацийКомплектацияНоменклатуры(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Комплектация => GetProperty<EnumItemBase>("Комплектация");
        public EnumItemBase Разукомплектация => GetProperty<EnumItemBase>("Разукомплектация");
    }
}

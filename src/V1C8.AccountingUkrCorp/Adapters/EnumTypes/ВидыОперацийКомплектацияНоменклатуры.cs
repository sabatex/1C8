using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийКомплектацияНоменклатуры:EnumBase
    {
        public ВидыОперацийКомплектацияНоменклатуры(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Комплектация => GetProperty<EnumItem>("Комплектация");
        public EnumItem Разукомплектация => GetProperty<EnumItem>("Разукомплектация");
    }
}

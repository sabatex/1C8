using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЕдиницыВремениУчетаСпецстажа:EnumBase
    {
        public ЕдиницыВремениУчетаСпецстажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem КалендарныеДни => GetProperty<EnumItem>("КалендарныеДни");
        public EnumItem Смены => GetProperty<EnumItem>("Смены");
        public EnumItem Часы => GetProperty<EnumItem>("Часы");
    }
}

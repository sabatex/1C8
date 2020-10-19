using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЕдиницыВремениУчетаСпецстажа:V1C8COMObject
    {
        public ЕдиницыВремениУчетаСпецстажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КалендарныеДни => GetProperty<EnumItemBase>("КалендарныеДни");
        public EnumItemBase Смены => GetProperty<EnumItemBase>("Смены");
        public EnumItemBase Часы => GetProperty<EnumItemBase>("Часы");
    }
}

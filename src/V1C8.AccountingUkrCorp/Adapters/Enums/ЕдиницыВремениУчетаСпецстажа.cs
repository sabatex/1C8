using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ЕдиницыВремениУчетаСпецстажа:V1C8COMObject
    {
        public ЕдиницыВремениУчетаСпецстажа(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КалендарныеДни => GetProperty<EnumItemBase>();
        public EnumItemBase Смены => GetProperty<EnumItemBase>();
        public EnumItemBase Часы => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКорректировокНалоговогоКредита:V1C8COMObject
    {
        public ВидыКорректировокНалоговогоКредита(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПотеряПраваНаНалоговыйКредит => GetProperty<EnumItemBase>("ПотеряПраваНаНалоговыйКредит");
        public EnumItemBase ВосстановлениеПраваНаНалоговыйКредит => GetProperty<EnumItemBase>("ВосстановлениеПраваНаНалоговыйКредит");
        public EnumItemBase НетКорректировок => GetProperty<EnumItemBase>("НетКорректировок");
    }
}

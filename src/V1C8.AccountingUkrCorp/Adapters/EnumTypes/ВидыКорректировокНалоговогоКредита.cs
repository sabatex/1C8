using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКорректировокНалоговогоКредита:EnumBase
    {
        public ВидыКорректировокНалоговогоКредита(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПотеряПраваНаНалоговыйКредит => GetProperty<EnumItem>("ПотеряПраваНаНалоговыйКредит");
        public EnumItem ВосстановлениеПраваНаНалоговыйКредит => GetProperty<EnumItem>("ВосстановлениеПраваНаНалоговыйКредит");
        public EnumItem НетКорректировок => GetProperty<EnumItem>("НетКорректировок");
    }
}

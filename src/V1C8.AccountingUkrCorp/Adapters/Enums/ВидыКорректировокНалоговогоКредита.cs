using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыКорректировокНалоговогоКредита:V1C8COMObject
    {
        public ВидыКорректировокНалоговогоКредита(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПотеряПраваНаНалоговыйКредит => GetProperty<EnumItemBase>();
        public EnumItemBase ВосстановлениеПраваНаНалоговыйКредит => GetProperty<EnumItemBase>();
        public EnumItemBase НетКорректировок => GetProperty<EnumItemBase>();
    }
}

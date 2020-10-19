using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МетодыКорректировкиНалоговогоКредита:V1C8COMObject
    {
        public МетодыКорректировкиНалоговогоКредита(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаНалоговыйКредит => GetProperty<EnumItemBase>("НаНалоговыйКредит");
        public EnumItemBase НаНалоговыеОбязательства => GetProperty<EnumItemBase>("НаНалоговыеОбязательства");
        public EnumItemBase НеКорректировать => GetProperty<EnumItemBase>("НеКорректировать");
    }
}

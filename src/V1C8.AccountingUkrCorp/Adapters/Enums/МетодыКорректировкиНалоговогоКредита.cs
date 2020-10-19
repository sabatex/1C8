using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class МетодыКорректировкиНалоговогоКредита:V1C8COMObject
    {
        public МетодыКорректировкиНалоговогоКредита(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаНалоговыйКредит => GetProperty<EnumItemBase>();
        public EnumItemBase НаНалоговыеОбязательства => GetProperty<EnumItemBase>();
        public EnumItemBase НеКорректировать => GetProperty<EnumItemBase>();
    }
}

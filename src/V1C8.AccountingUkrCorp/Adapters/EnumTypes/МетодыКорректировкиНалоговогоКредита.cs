using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МетодыКорректировкиНалоговогоКредита:EnumBase
    {
        public МетодыКорректировкиНалоговогоКредита(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НаНалоговыйКредит => GetProperty<EnumItem>("НаНалоговыйКредит");
        public EnumItem НаНалоговыеОбязательства => GetProperty<EnumItem>("НаНалоговыеОбязательства");
        public EnumItem НеКорректировать => GetProperty<EnumItem>("НеКорректировать");
    }
}

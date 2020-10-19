using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыСуммДляВводаОстатков:V1C8COMObject
    {
        public ТипыСуммДляВводаОстатков(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оборот => GetProperty<EnumItemBase>();
        public EnumItemBase ОстатокНаНачало => GetProperty<EnumItemBase>();
    }
}

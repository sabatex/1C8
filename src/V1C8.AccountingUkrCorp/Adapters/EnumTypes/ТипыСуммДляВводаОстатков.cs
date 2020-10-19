using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСуммДляВводаОстатков:V1C8COMObject
    {
        public ТипыСуммДляВводаОстатков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оборот => GetProperty<EnumItemBase>("Оборот");
        public EnumItemBase ОстатокНаНачало => GetProperty<EnumItemBase>("ОстатокНаНачало");
    }
}

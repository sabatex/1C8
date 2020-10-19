using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСуммДляВводаОстатков:EnumBase
    {
        public ТипыСуммДляВводаОстатков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Оборот => GetProperty<EnumItem>("Оборот");
        public EnumItem ОстатокНаНачало => GetProperty<EnumItem>("ОстатокНаНачало");
    }
}

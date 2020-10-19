using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодОчисткиФайлов:EnumBase
    {
        public ПериодОчисткиФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СтаршеМесяца => GetProperty<EnumItem>("СтаршеМесяца");
        public EnumItem СтаршеШестиМесяцев => GetProperty<EnumItem>("СтаршеШестиМесяцев");
        public EnumItem СтаршеГода => GetProperty<EnumItem>("СтаршеГода");
        public EnumItem ПоПравилу => GetProperty<EnumItem>("ПоПравилу");
    }
}

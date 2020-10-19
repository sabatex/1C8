using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодОчисткиФайлов:V1C8COMObject
    {
        public ПериодОчисткиФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СтаршеМесяца => GetProperty<EnumItemBase>("СтаршеМесяца");
        public EnumItemBase СтаршеШестиМесяцев => GetProperty<EnumItemBase>("СтаршеШестиМесяцев");
        public EnumItemBase СтаршеГода => GetProperty<EnumItemBase>("СтаршеГода");
        public EnumItemBase ПоПравилу => GetProperty<EnumItemBase>("ПоПравилу");
    }
}

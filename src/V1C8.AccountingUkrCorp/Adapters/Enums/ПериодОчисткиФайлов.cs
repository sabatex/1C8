using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПериодОчисткиФайлов:V1C8COMObject
    {
        public ПериодОчисткиФайлов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СтаршеМесяца => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршеШестиМесяцев => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршеГода => GetProperty<EnumItemBase>();
        public EnumItemBase ПоПравилу => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПризовПодарков:V1C8COMObject
    {
        public ВидыПризовПодарков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Подарок => GetProperty<EnumItemBase>("Подарок");
        public EnumItemBase Приз => GetProperty<EnumItemBase>("Приз");
    }
}

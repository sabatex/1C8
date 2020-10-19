using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПризовПодарков:EnumBase
    {
        public ВидыПризовПодарков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Подарок => GetProperty<EnumItem>("Подарок");
        public EnumItem Приз => GetProperty<EnumItem>("Приз");
    }
}

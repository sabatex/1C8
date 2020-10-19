using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПравилаОкругленияПриРасчетеЗарплаты:EnumBase
    {
        public ПравилаОкругленияПриРасчетеЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Авто => GetProperty<EnumItem>("Авто");
        public EnumItem ВМеньшуюСторону => GetProperty<EnumItem>("ВМеньшуюСторону");
        public EnumItem ВБольшуюСторону => GetProperty<EnumItem>("ВБольшуюСторону");
    }
}

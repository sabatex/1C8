using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПравилаОкругленияПриРасчетеЗарплаты:V1C8COMObject
    {
        public ПравилаОкругленияПриРасчетеЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Авто => GetProperty<EnumItemBase>("Авто");
        public EnumItemBase ВМеньшуюСторону => GetProperty<EnumItemBase>("ВМеньшуюСторону");
        public EnumItemBase ВБольшуюСторону => GetProperty<EnumItemBase>("ВБольшуюСторону");
    }
}

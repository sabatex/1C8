using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПримененияЗначенийПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public СпособыПримененияЗначенийПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постоянное => GetProperty<EnumItemBase>("Постоянное");
        public EnumItemBase Разовое => GetProperty<EnumItemBase>("Разовое");
    }
}

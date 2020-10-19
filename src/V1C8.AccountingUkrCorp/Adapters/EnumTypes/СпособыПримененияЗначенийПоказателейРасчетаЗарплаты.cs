using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПримененияЗначенийПоказателейРасчетаЗарплаты:EnumBase
    {
        public СпособыПримененияЗначенийПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Постоянное => GetProperty<EnumItem>("Постоянное");
        public EnumItem Разовое => GetProperty<EnumItem>("Разовое");
    }
}

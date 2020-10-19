using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыПримененияЗначенийПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public СпособыПримененияЗначенийПоказателейРасчетаЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постоянное => GetProperty<EnumItemBase>();
        public EnumItemBase Разовое => GetProperty<EnumItemBase>();
    }
}

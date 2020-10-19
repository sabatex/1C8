using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыВводаЗначенийПоказателейРасчетаЗарплаты:EnumBase
    {
        public СпособыВводаЗначенийПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВводитсяЕдиновременно => GetProperty<EnumItem>("ВводитсяЕдиновременно");
        public EnumItem НакапливаетсяПоОтдельнымЗначениям => GetProperty<EnumItem>("НакапливаетсяПоОтдельнымЗначениям");
        public EnumItem ВводитсяПриРасчете => GetProperty<EnumItem>("ВводитсяПриРасчете");
    }
}

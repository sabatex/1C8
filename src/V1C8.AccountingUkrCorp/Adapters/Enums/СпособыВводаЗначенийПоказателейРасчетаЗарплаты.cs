using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыВводаЗначенийПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public СпособыВводаЗначенийПоказателейРасчетаЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВводитсяЕдиновременно => GetProperty<EnumItemBase>();
        public EnumItemBase НакапливаетсяПоОтдельнымЗначениям => GetProperty<EnumItemBase>();
        public EnumItemBase ВводитсяПриРасчете => GetProperty<EnumItemBase>();
    }
}

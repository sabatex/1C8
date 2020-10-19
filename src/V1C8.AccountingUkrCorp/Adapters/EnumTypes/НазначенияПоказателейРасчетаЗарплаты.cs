using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class НазначенияПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public НазначенияПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДляСотрудника => GetProperty<EnumItemBase>("ДляСотрудника");
        public EnumItemBase ДляПодразделения => GetProperty<EnumItemBase>("ДляПодразделения");
        public EnumItemBase ДляОрганизации => GetProperty<EnumItemBase>("ДляОрганизации");
    }
}

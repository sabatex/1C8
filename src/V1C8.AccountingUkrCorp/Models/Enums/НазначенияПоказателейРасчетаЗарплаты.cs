using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "НазначенияПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Назначения показателей расчета зарплаты")]
    public class НазначенияПоказателейРасчетаЗарплаты:EnumItem
    {
        public static readonly НазначенияПоказателейРасчетаЗарплаты ДляСотрудника = new НазначенияПоказателейРасчетаЗарплаты{Name= "ДляСотрудника",Synonim="Для сотрудника",Comment=""};
        public static readonly НазначенияПоказателейРасчетаЗарплаты ДляПодразделения = new НазначенияПоказателейРасчетаЗарплаты{Name= "ДляПодразделения",Synonim="Для подразделения",Comment=""};
        public static readonly НазначенияПоказателейРасчетаЗарплаты ДляОрганизации = new НазначенияПоказателейРасчетаЗарплаты{Name= "ДляОрганизации",Synonim="Для организации",Comment=""};
    }
}

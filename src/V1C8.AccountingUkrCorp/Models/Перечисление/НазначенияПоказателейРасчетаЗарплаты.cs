using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "НазначенияПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Назначения показателей расчета зарплаты")]
    public enum НазначенияПоказателейРасчетаЗарплаты
    {
        [Description1C8(Name = "ДляСотрудника", Comment = "", Synonym = "Для сотрудника")]
        ДляСотрудника,
        [Description1C8(Name = "ДляПодразделения", Comment = "", Synonym = "Для подразделения")]
        ДляПодразделения,
        [Description1C8(Name = "ДляОрганизации", Comment = "", Synonym = "Для организации")]
        ДляОрганизации
    }
}

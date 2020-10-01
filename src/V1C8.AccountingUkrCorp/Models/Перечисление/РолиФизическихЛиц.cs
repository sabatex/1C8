using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РолиФизическихЛиц", Comment = "", Synonym = "Роли физических лиц")]
    public enum РолиФизическихЛиц
    {
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        Сотрудник,
        [Description1C8(Name = "БывшийСотрудник", Comment = "", Synonym = "Бывший сотрудник")]
        БывшийСотрудник,
        [Description1C8(Name = "Акционер", Comment = "", Synonym = "Акционер")]
        Акционер,
        [Description1C8(Name = "ПрочийПолучательДоходов", Comment = "", Synonym = "Прочий получатель доходов")]
        ПрочийПолучательДоходов,
        [Description1C8(Name = "РаздатчикЗарплаты", Comment = "", Synonym = "Раздатчик зарплаты")]
        РаздатчикЗарплаты,
        [Description1C8(Name = "Кандидат", Comment = "", Synonym = "Кандидат")]
        Кандидат
    }
}

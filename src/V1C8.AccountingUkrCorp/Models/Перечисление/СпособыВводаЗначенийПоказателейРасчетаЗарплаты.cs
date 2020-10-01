using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВводаЗначенийПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Способы ввода значений показателей расчета зарплаты")]
    public enum СпособыВводаЗначенийПоказателейРасчетаЗарплаты
    {
        [Description1C8(Name = "ВводитсяЕдиновременно", Comment = "", Synonym = "Вводится единовременно")]
        ВводитсяЕдиновременно,
        [Description1C8(Name = "НакапливаетсяПоОтдельнымЗначениям", Comment = "", Synonym = "Накапливается по отдельным значениям")]
        НакапливаетсяПоОтдельнымЗначениям,
        [Description1C8(Name = "ВводитсяПриРасчете", Comment = "", Synonym = "Вводится при расчете")]
        ВводитсяПриРасчете
    }
}

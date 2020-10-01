using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПримененияЗначенийПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Способы применения значений показателей расчета зарплаты")]
    public enum СпособыПримененияЗначенийПоказателейРасчетаЗарплаты
    {
        [Description1C8(Name = "Постоянное", Comment = "", Synonym = "Во всех месяцах после ввода значения (постоянное использование)")]
        Постоянное,
        [Description1C8(Name = "Разовое", Comment = "", Synonym = "Только в месяце, в котором вводится значение (разовое использование)")]
        Разовое
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимНачисленияЗарплаты", Comment = "", Synonym = "Режим начисления зарплаты")]
    public enum РежимНачисленияЗарплаты
    {
        [Description1C8(Name = "ОкончательныйРасчет", Comment = "", Synonym = "Окончательный расчет")]
        ОкончательныйРасчет,
        [Description1C8(Name = "РасчетПервойПоловиныМесяца", Comment = "", Synonym = "Расчет первой половины месяца")]
        РасчетПервойПоловиныМесяца
    }
}

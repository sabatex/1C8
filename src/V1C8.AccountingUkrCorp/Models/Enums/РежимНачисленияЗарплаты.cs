using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимНачисленияЗарплаты", Comment = "", Synonym = "Режим начисления зарплаты")]
    public class РежимНачисленияЗарплаты:EnumItem
    {
        public static readonly РежимНачисленияЗарплаты ОкончательныйРасчет = new РежимНачисленияЗарплаты{Name= "ОкончательныйРасчет",Synonim="Окончательный расчет",Comment=""};
        public static readonly РежимНачисленияЗарплаты РасчетПервойПоловиныМесяца = new РежимНачисленияЗарплаты{Name= "РасчетПервойПоловиныМесяца",Synonim="Расчет первой половины месяца",Comment=""};
    }
}

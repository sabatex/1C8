using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("RezhymNachyslenyiaZarplaty")]
    [Description1C8(Name = "РежимНачисленияЗарплаты", Comment = "", Synonym = "Режим начисления зарплаты")]
    public class РежимНачисленияЗарплаты:EnumItem
    {
        public static readonly РежимНачисленияЗарплаты ОкончательныйРасчет = new РежимНачисленияЗарплаты{Name= "ОкончательныйРасчет",Synonym="Окончательный расчет",Comment=""};
        public static readonly РежимНачисленияЗарплаты РасчетПервойПоловиныМесяца = new РежимНачисленияЗарплаты{Name= "РасчетПервойПоловиныМесяца",Synonym="Расчет первой половины месяца",Comment=""};
    }
}

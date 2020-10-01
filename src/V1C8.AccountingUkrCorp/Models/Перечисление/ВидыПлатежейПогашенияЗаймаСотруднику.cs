using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПлатежейПогашенияЗаймаСотруднику", Comment = "", Synonym = "Виды платежей погашения займа сотруднику")]
    public enum ВидыПлатежейПогашенияЗаймаСотруднику
    {
        [Description1C8(Name = "ДифференцированныеПлатежи", Comment = "", Synonym = "Дифференцированные платежи")]
        ДифференцированныеПлатежи,
        [Description1C8(Name = "АннуитетныеПлатежи", Comment = "", Synonym = "Аннуитетные платежи")]
        АннуитетныеПлатежи,
        [Description1C8(Name = "ТолькоПроценты", Comment = "", Synonym = "Только проценты (заем в конце срока)")]
        ТолькоПроценты,
        [Description1C8(Name = "ТолькоЗаем", Comment = "", Synonym = "Только заем (проценты в конце срока)")]
        ТолькоЗаем
    }
}

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
    [Table("VydyPlatezheiPohashenyiaZaimaSotrudnyku")]
    [Description1C8(Name = "ВидыПлатежейПогашенияЗаймаСотруднику", Comment = "", Synonym = "Виды платежей погашения займа сотруднику")]
    public class ВидыПлатежейПогашенияЗаймаСотруднику:EnumItem
    {
        public static readonly ВидыПлатежейПогашенияЗаймаСотруднику ДифференцированныеПлатежи = new ВидыПлатежейПогашенияЗаймаСотруднику{Name= "ДифференцированныеПлатежи",Synonym="Дифференцированные платежи",Comment=""};
        public static readonly ВидыПлатежейПогашенияЗаймаСотруднику АннуитетныеПлатежи = new ВидыПлатежейПогашенияЗаймаСотруднику{Name= "АннуитетныеПлатежи",Synonym="Аннуитетные платежи",Comment=""};
        public static readonly ВидыПлатежейПогашенияЗаймаСотруднику ТолькоПроценты = new ВидыПлатежейПогашенияЗаймаСотруднику{Name= "ТолькоПроценты",Synonym="Только проценты (заем в конце срока)",Comment=""};
        public static readonly ВидыПлатежейПогашенияЗаймаСотруднику ТолькоЗаем = new ВидыПлатежейПогашенияЗаймаСотруднику{Name= "ТолькоЗаем",Synonym="Только заем (проценты в конце срока)",Comment=""};
    }
}

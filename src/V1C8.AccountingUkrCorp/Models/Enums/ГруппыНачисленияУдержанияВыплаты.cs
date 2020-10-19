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
    [Table("HruppyNachyslenyiaUderzhanyiaVyplaty")]
    [Description1C8(Name = "ГруппыНачисленияУдержанияВыплаты", Comment = "", Synonym = "Группы начисления удержания выплаты")]
    public class ГруппыНачисленияУдержанияВыплаты:EnumItem
    {
        public static readonly ГруппыНачисленияУдержанияВыплаты НачальноеСальдоПериода = new ГруппыНачисленияУдержанияВыплаты{Name= "НачальноеСальдоПериода",Synonym="Входящее сальдо периода",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты НачальноеСальдо = new ГруппыНачисленияУдержанияВыплаты{Name= "НачальноеСальдо",Synonym="Входящее сальдо месяца",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Начислено = new ГруппыНачисленияУдержанияВыплаты{Name= "Начислено",Synonym="Начислено",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Удержано = new ГруппыНачисленияУдержанияВыплаты{Name= "Удержано",Synonym="Удержано",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Выплачено = new ГруппыНачисленияУдержанияВыплаты{Name= "Выплачено",Synonym="Выплачено",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты КонечноеСальдо = new ГруппыНачисленияУдержанияВыплаты{Name= "КонечноеСальдо",Synonym="Сальдо по итогам расчетов за месяц",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты КонечноеСальдоПериода = new ГруппыНачисленияУдержанияВыплаты{Name= "КонечноеСальдоПериода",Synonym="Сальдо по итогам расчетов за период",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Справочно = new ГруппыНачисленияУдержанияВыплаты{Name= "Справочно",Synonym="Справочно",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Льготы = new ГруппыНачисленияУдержанияВыплаты{Name= "Льготы",Synonym="Льготы",Comment=""};
    }
}

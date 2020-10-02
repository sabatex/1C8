using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыНачисленияУдержанияВыплаты", Comment = "", Synonym = "Группы начисления удержания выплаты")]
    public class ГруппыНачисленияУдержанияВыплаты:EnumItem
    {
        public static readonly ГруппыНачисленияУдержанияВыплаты НачальноеСальдоПериода = new ГруппыНачисленияУдержанияВыплаты{Name= "НачальноеСальдоПериода",Synonim="Входящее сальдо периода",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты НачальноеСальдо = new ГруппыНачисленияУдержанияВыплаты{Name= "НачальноеСальдо",Synonim="Входящее сальдо месяца",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Начислено = new ГруппыНачисленияУдержанияВыплаты{Name= "Начислено",Synonim="Начислено",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Удержано = new ГруппыНачисленияУдержанияВыплаты{Name= "Удержано",Synonim="Удержано",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Выплачено = new ГруппыНачисленияУдержанияВыплаты{Name= "Выплачено",Synonim="Выплачено",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты КонечноеСальдо = new ГруппыНачисленияУдержанияВыплаты{Name= "КонечноеСальдо",Synonim="Сальдо по итогам расчетов за месяц",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты КонечноеСальдоПериода = new ГруппыНачисленияУдержанияВыплаты{Name= "КонечноеСальдоПериода",Synonim="Сальдо по итогам расчетов за период",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Справочно = new ГруппыНачисленияУдержанияВыплаты{Name= "Справочно",Synonim="Справочно",Comment=""};
        public static readonly ГруппыНачисленияУдержанияВыплаты Льготы = new ГруппыНачисленияУдержанияВыплаты{Name= "Льготы",Synonim="Льготы",Comment=""};
    }
}

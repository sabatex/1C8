using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостояниеЗачисленияЗарплаты", Comment = "", Synonym = "Состояние зачисления зарплаты")]
    public class СостояниеЗачисленияЗарплаты:EnumItem
    {
        public static readonly СостояниеЗачисленияЗарплаты ОжидаетПодтверждения = new СостояниеЗачисленияЗарплаты{Name= "ОжидаетПодтверждения",Synonim="Выгружен в банк",Comment=""};
        public static readonly СостояниеЗачисленияЗарплаты ГотовКВыгрузке = new СостояниеЗачисленияЗарплаты{Name= "ГотовКВыгрузке",Synonim="Готов к выгрузке",Comment=""};
        public static readonly СостояниеЗачисленияЗарплаты ЗачисленоПолностью = new СостояниеЗачисленияЗарплаты{Name= "ЗачисленоПолностью",Synonim="Зачислено полностью",Comment=""};
        public static readonly СостояниеЗачисленияЗарплаты ЗачисленоСОшибками = new СостояниеЗачисленияЗарплаты{Name= "ЗачисленоСОшибками",Synonim="Зачислено с ошибками (частично)",Comment=""};
        public static readonly СостояниеЗачисленияЗарплаты НеЗачислено = new СостояниеЗачисленияЗарплаты{Name= "НеЗачислено",Synonim="Не зачислено (все строки - ошибки)",Comment=""};
    }
}

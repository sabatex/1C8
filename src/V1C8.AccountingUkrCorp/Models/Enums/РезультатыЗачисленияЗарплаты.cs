using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыЗачисленияЗарплаты", Comment = "", Synonym = "Результаты зачисления зарплаты")]
    public class РезультатыЗачисленияЗарплаты:EnumItem
    {
        public static readonly РезультатыЗачисленияЗарплаты Зачислено = new РезультатыЗачисленияЗарплаты{Name= "Зачислено",Synonim="Зачислено",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты ОшибкаФИО = new РезультатыЗачисленияЗарплаты{Name= "ОшибкаФИО",Synonim="Ошибка ФИО",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты СчетЗакрыт = new РезультатыЗачисленияЗарплаты{Name= "СчетЗакрыт",Synonim="Счет закрыт",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты СчетОтсутствует = new РезультатыЗачисленияЗарплаты{Name= "СчетОтсутствует",Synonim="Счет отсутствует",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты НеЗачислено = new РезультатыЗачисленияЗарплаты{Name= "НеЗачислено",Synonim="Не зачислено",Comment=""};
    }
}

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
    [Table("RezultatyZachyslenyiaZarplaty")]
    [Description1C8(Name = "РезультатыЗачисленияЗарплаты", Comment = "", Synonym = "Результаты зачисления зарплаты")]
    public class РезультатыЗачисленияЗарплаты:EnumItem
    {
        public static readonly РезультатыЗачисленияЗарплаты Зачислено = new РезультатыЗачисленияЗарплаты{Name= "Зачислено",Synonym="Зачислено",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты ОшибкаФИО = new РезультатыЗачисленияЗарплаты{Name= "ОшибкаФИО",Synonym="Ошибка ФИО",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты СчетЗакрыт = new РезультатыЗачисленияЗарплаты{Name= "СчетЗакрыт",Synonym="Счет закрыт",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты СчетОтсутствует = new РезультатыЗачисленияЗарплаты{Name= "СчетОтсутствует",Synonym="Счет отсутствует",Comment=""};
        public static readonly РезультатыЗачисленияЗарплаты НеЗачислено = new РезультатыЗачисленияЗарплаты{Name= "НеЗачислено",Synonym="Не зачислено",Comment=""};
    }
}

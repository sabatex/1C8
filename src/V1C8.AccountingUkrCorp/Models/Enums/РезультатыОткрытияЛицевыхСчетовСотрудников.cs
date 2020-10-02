using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыОткрытияЛицевыхСчетовСотрудников", Comment = "", Synonym = "Результаты открытия лицевых счетов сотрудников")]
    public class РезультатыОткрытияЛицевыхСчетовСотрудников:EnumItem
    {
        public static readonly РезультатыОткрытияЛицевыхСчетовСотрудников СчетОткрыт = new РезультатыОткрытияЛицевыхСчетовСотрудников{Name= "СчетОткрыт",Synonim="Счет открыт",Comment=""};
        public static readonly РезультатыОткрытияЛицевыхСчетовСотрудников ОшибкаЗаполненияДанных = new РезультатыОткрытияЛицевыхСчетовСотрудников{Name= "ОшибкаЗаполненияДанных",Synonim="Ошибка заполнения данных",Comment=""};
        public static readonly РезультатыОткрытияЛицевыхСчетовСотрудников СчетНеОткрыт = new РезультатыОткрытияЛицевыхСчетовСотрудников{Name= "СчетНеОткрыт",Synonim="Счет не открыт",Comment=""};
    }
}

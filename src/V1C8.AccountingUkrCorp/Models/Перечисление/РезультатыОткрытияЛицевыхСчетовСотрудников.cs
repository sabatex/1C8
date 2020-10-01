using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыОткрытияЛицевыхСчетовСотрудников", Comment = "", Synonym = "Результаты открытия лицевых счетов сотрудников")]
    public enum РезультатыОткрытияЛицевыхСчетовСотрудников
    {
        [Description1C8(Name = "СчетОткрыт", Comment = "", Synonym = "Счет открыт")]
        СчетОткрыт,
        [Description1C8(Name = "ОшибкаЗаполненияДанных", Comment = "", Synonym = "Ошибка заполнения данных")]
        ОшибкаЗаполненияДанных,
        [Description1C8(Name = "СчетНеОткрыт", Comment = "", Synonym = "Счет не открыт")]
        СчетНеОткрыт
    }
}

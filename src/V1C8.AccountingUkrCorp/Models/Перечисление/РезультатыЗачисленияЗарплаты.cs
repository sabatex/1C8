using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыЗачисленияЗарплаты", Comment = "", Synonym = "Результаты зачисления зарплаты")]
    public enum РезультатыЗачисленияЗарплаты
    {
        [Description1C8(Name = "Зачислено", Comment = "", Synonym = "Зачислено")]
        Зачислено,
        [Description1C8(Name = "ОшибкаФИО", Comment = "", Synonym = "Ошибка ФИО")]
        ОшибкаФИО,
        [Description1C8(Name = "СчетЗакрыт", Comment = "", Synonym = "Счет закрыт")]
        СчетЗакрыт,
        [Description1C8(Name = "СчетОтсутствует", Comment = "", Synonym = "Счет отсутствует")]
        СчетОтсутствует,
        [Description1C8(Name = "НеЗачислено", Comment = "", Synonym = "Не зачислено")]
        НеЗачислено
    }
}

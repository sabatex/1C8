using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДействияСНачислением", Comment = "(Общ)", Synonym = "Виды действия с начислением")]
    public enum ВидыДействияСНачислением
    {
        [Description1C8(Name = "Начать", Comment = "(Общ)", Synonym = "Начать")]
        Начать,
        [Description1C8(Name = "Изменить", Comment = "(Общ)", Synonym = "Изменить")]
        Изменить,
        [Description1C8(Name = "НеИзменять", Comment = "(Общ)", Synonym = "Не изменять")]
        НеИзменять,
        [Description1C8(Name = "Прекратить", Comment = "(Общ)", Synonym = "Прекратить")]
        Прекратить
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСотрудниковОбменаСБанками", Comment = "", Synonym = "Категории сотрудников обмена с банками")]
    public enum КатегорииСотрудниковОбменаСБанками
    {
        [Description1C8(Name = "Прочие", Comment = "", Synonym = "Прочие")]
        Прочие,
        [Description1C8(Name = "Пенсионеры", Comment = "", Synonym = "Пенсионеры")]
        Пенсионеры,
        [Description1C8(Name = "Студенты", Comment = "", Synonym = "Студенты")]
        Студенты
    }
}

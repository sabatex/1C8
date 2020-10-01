using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыКалендарей", Comment = "", Synonym = "(не используется) Виды календарей")]
    public enum УдалитьВидыКалендарей
    {
        [Description1C8(Name = "Пятидневка", Comment = "", Synonym = "Пятидневка")]
        Пятидневка,
        [Description1C8(Name = "Шестидневка", Comment = "", Synonym = "Шестидневка")]
        Шестидневка,
        [Description1C8(Name = "Произвольный", Comment = "", Synonym = "Произвольный")]
        Произвольный
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыКонтрагентов", Comment = "(Общ)", Synonym = "Статусы контрагентов")]
    public enum СтатусыКонтрагентов
    {
        [Description1C8(Name = "Покупатель", Comment = "(Общ)", Synonym = "Покупатель")]
        Покупатель,
        [Description1C8(Name = "Поставщик", Comment = "(Общ)", Synonym = "Поставщик")]
        Поставщик,
        [Description1C8(Name = "Прочее", Comment = "(Общ)", Synonym = "Прочее")]
        Прочее
    }
}

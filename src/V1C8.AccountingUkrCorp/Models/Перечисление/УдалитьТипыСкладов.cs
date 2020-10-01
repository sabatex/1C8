using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьТипыСкладов", Comment = "(Общ)", Synonym = "(не используется) Типы складов")]
    public enum УдалитьТипыСкладов
    {
        [Description1C8(Name = "Оптовый", Comment = "(Общ) Оптовый склад", Synonym = "Оптовый")]
        Оптовый,
        [Description1C8(Name = "Розничный", Comment = "(Общ) Розничный", Synonym = "Розничный")]
        Розничный
    }
}

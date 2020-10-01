using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтавкиНДС", Comment = "(Общ)", Synonym = "Ставки НДС")]
    public enum СтавкиНДС
    {
        [Description1C8(Name = "НДС20", Comment = "(Общ) Ставка НДС 20%", Synonym = "20%")]
        НДС20,
        [Description1C8(Name = "НДС7", Comment = "", Synonym = "7%")]
        НДС7,
        [Description1C8(Name = "НДС0", Comment = "(Общ) Ставка НДС 0%", Synonym = "0%")]
        НДС0,
        [Description1C8(Name = "БезНДС", Comment = "(Общ)", Synonym = "Без НДС")]
        БезНДС,
        [Description1C8(Name = "НеНДС", Comment = "", Synonym = "Не НДС")]
        НеНДС
    }
}

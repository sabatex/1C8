using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьНаборПравПользователей", Comment = "", Synonym = "(не используется) Набор прав пользователей")]
    public enum УдалитьНаборПравПользователей
    {
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        Бухгалтер,
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        ГлавныйБухгалтер,
        [Description1C8(Name = "ПолныеПрава", Comment = "", Synonym = "Полные права")]
        ПолныеПрава
    }
}

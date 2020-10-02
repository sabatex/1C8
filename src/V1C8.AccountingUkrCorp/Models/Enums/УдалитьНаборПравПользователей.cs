using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьНаборПравПользователей", Comment = "", Synonym = "(не используется) Набор прав пользователей")]
    public class УдалитьНаборПравПользователей:EnumItem
    {
        public static readonly УдалитьНаборПравПользователей Бухгалтер = new УдалитьНаборПравПользователей{Name= "Бухгалтер",Synonim="Бухгалтер",Comment=""};
        public static readonly УдалитьНаборПравПользователей ГлавныйБухгалтер = new УдалитьНаборПравПользователей{Name= "ГлавныйБухгалтер",Synonim="Главный бухгалтер",Comment=""};
        public static readonly УдалитьНаборПравПользователей ПолныеПрава = new УдалитьНаборПравПользователей{Name= "ПолныеПрава",Synonim="Полные права",Comment=""};
    }
}

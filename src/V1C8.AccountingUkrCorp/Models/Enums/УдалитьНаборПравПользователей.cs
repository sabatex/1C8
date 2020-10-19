using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("UdalytNaborPravPolzovatelei")]
    [Description1C8(Name = "УдалитьНаборПравПользователей", Comment = "", Synonym = "(не используется) Набор прав пользователей")]
    public class УдалитьНаборПравПользователей:EnumItem
    {
        public static readonly УдалитьНаборПравПользователей Бухгалтер = new УдалитьНаборПравПользователей{Name= "Бухгалтер",Synonym="Бухгалтер",Comment=""};
        public static readonly УдалитьНаборПравПользователей ГлавныйБухгалтер = new УдалитьНаборПравПользователей{Name= "ГлавныйБухгалтер",Synonym="Главный бухгалтер",Comment=""};
        public static readonly УдалитьНаборПравПользователей ПолныеПрава = new УдалитьНаборПравПользователей{Name= "ПолныеПрава",Synonym="Полные права",Comment=""};
    }
}

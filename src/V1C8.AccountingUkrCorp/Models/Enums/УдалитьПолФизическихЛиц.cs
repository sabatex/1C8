using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьПолФизическихЛиц", Comment = "", Synonym = "(не используется) Пол физических Лиц")]
    public class УдалитьПолФизическихЛиц:EnumItem
    {
        public static readonly УдалитьПолФизическихЛиц Мужской = new УдалитьПолФизическихЛиц{Name= "Мужской",Synonim="Мужской",Comment="(Общ)"};
        public static readonly УдалитьПолФизическихЛиц Женский = new УдалитьПолФизическихЛиц{Name= "Женский",Synonim="Женский",Comment="(Общ)"};
    }
}

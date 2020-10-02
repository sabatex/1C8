using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьТипыСкладов", Comment = "(Общ)", Synonym = "(не используется) Типы складов")]
    public class УдалитьТипыСкладов:EnumItem
    {
        public static readonly УдалитьТипыСкладов Оптовый = new УдалитьТипыСкладов{Name= "Оптовый",Synonim="Оптовый",Comment="(Общ) Оптовый склад"};
        public static readonly УдалитьТипыСкладов Розничный = new УдалитьТипыСкладов{Name= "Розничный",Synonim="Розничный",Comment="(Общ) Розничный"};
    }
}

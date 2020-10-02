using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыОбластейДанных", Comment = "", Synonym = "Статусы областей данных")]
    public class СтатусыОбластейДанных:EnumItem
    {
        public static readonly СтатусыОбластейДанных Новая = new СтатусыОбластейДанных{Name= "Новая",Synonim="Новая",Comment=""};
        public static readonly СтатусыОбластейДанных Используется = new СтатусыОбластейДанных{Name= "Используется",Synonim="Используется",Comment=""};
        public static readonly СтатусыОбластейДанных КУдалению = new СтатусыОбластейДанных{Name= "КУдалению",Synonim="К удалению",Comment=""};
        public static readonly СтатусыОбластейДанных Удалена = new СтатусыОбластейДанных{Name= "Удалена",Synonim="Удалена",Comment=""};
        public static readonly СтатусыОбластейДанных ИмпортИзФайла = new СтатусыОбластейДанных{Name= "ИмпортИзФайла",Synonim="Импорт из файла",Comment=""};
    }
}

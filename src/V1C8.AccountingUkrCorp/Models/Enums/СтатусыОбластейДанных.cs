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
    [Table("StatusyOblasteiDannykh")]
    [Description1C8(Name = "СтатусыОбластейДанных", Comment = "", Synonym = "Статусы областей данных")]
    public class СтатусыОбластейДанных:EnumItem
    {
        public static readonly СтатусыОбластейДанных Новая = new СтатусыОбластейДанных{Name= "Новая",Synonym="Новая",Comment=""};
        public static readonly СтатусыОбластейДанных Используется = new СтатусыОбластейДанных{Name= "Используется",Synonym="Используется",Comment=""};
        public static readonly СтатусыОбластейДанных КУдалению = new СтатусыОбластейДанных{Name= "КУдалению",Synonym="К удалению",Comment=""};
        public static readonly СтатусыОбластейДанных Удалена = new СтатусыОбластейДанных{Name= "Удалена",Synonym="Удалена",Comment=""};
        public static readonly СтатусыОбластейДанных ИмпортИзФайла = new СтатусыОбластейДанных{Name= "ИмпортИзФайла",Synonym="Импорт из файла",Comment=""};
    }
}

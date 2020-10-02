using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыРегистрацииВЕРНННалоговыхДокументов", Comment = "", Synonym = "Статусы регистрации ВЕРНННалоговых документов")]
    public class СтатусыРегистрацииВЕРНННалоговыхДокументов:EnumItem
    {
        public static readonly СтатусыРегистрацииВЕРНННалоговыхДокументов НеЗарегистрированВЕРНН = new СтатусыРегистрацииВЕРНННалоговыхДокументов{Name= "НеЗарегистрированВЕРНН",Synonym="Не зарегистрирован в ЕРНН",Comment=""};
        public static readonly СтатусыРегистрацииВЕРНННалоговыхДокументов НаправленНаРегистрациюВЕРНН = new СтатусыРегистрацииВЕРНННалоговыхДокументов{Name= "НаправленНаРегистрациюВЕРНН",Synonym="Направлен на регистрацию в ЕРНН",Comment=""};
        public static readonly СтатусыРегистрацииВЕРНННалоговыхДокументов ОтказаноВРегистрацииВЕРНН = new СтатусыРегистрацииВЕРНННалоговыхДокументов{Name= "ОтказаноВРегистрацииВЕРНН",Synonym="Отказано в регистрации в ЕРНН",Comment=""};
        public static readonly СтатусыРегистрацииВЕРНННалоговыхДокументов ЗарегистрированВЕРНН = new СтатусыРегистрацииВЕРНННалоговыхДокументов{Name= "ЗарегистрированВЕРНН",Synonym="Зарегистрирован в ЕРНН",Comment=""};
    }
}

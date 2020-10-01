using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыРегистрацииВЕРНННалоговыхДокументов", Comment = "", Synonym = "Статусы регистрации ВЕРНННалоговых документов")]
    public enum СтатусыРегистрацииВЕРНННалоговыхДокументов
    {
        [Description1C8(Name = "НеЗарегистрированВЕРНН", Comment = "", Synonym = "Не зарегистрирован в ЕРНН")]
        НеЗарегистрированВЕРНН,
        [Description1C8(Name = "НаправленНаРегистрациюВЕРНН", Comment = "", Synonym = "Направлен на регистрацию в ЕРНН")]
        НаправленНаРегистрациюВЕРНН,
        [Description1C8(Name = "ОтказаноВРегистрацииВЕРНН", Comment = "", Synonym = "Отказано в регистрации в ЕРНН")]
        ОтказаноВРегистрацииВЕРНН,
        [Description1C8(Name = "ЗарегистрированВЕРНН", Comment = "", Synonym = "Зарегистрирован в ЕРНН")]
        ЗарегистрированВЕРНН
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПравилДляОбменаДанными", Comment = "", Synonym = "Виды правил для обмена данными")]
    public enum ВидыПравилДляОбменаДанными
    {
        [Description1C8(Name = "ПравилаКонвертацииОбъектов", Comment = "", Synonym = "Правила конвертации объектов")]
        ПравилаКонвертацииОбъектов,
        [Description1C8(Name = "ПравилаРегистрацииОбъектов", Comment = "", Synonym = "Правила регистрации объектов")]
        ПравилаРегистрацииОбъектов
    }
}

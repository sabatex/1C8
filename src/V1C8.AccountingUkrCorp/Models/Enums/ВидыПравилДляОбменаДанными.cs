using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПравилДляОбменаДанными", Comment = "", Synonym = "Виды правил для обмена данными")]
    public class ВидыПравилДляОбменаДанными:EnumItem
    {
        public static readonly ВидыПравилДляОбменаДанными ПравилаКонвертацииОбъектов = new ВидыПравилДляОбменаДанными{Name= "ПравилаКонвертацииОбъектов",Synonim="Правила конвертации объектов",Comment=""};
        public static readonly ВидыПравилДляОбменаДанными ПравилаРегистрацииОбъектов = new ВидыПравилДляОбменаДанными{Name= "ПравилаРегистрацииОбъектов",Synonim="Правила регистрации объектов",Comment=""};
    }
}

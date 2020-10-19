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
    [Table("VydyPravylDliaObmenaDannymy")]
    [Description1C8(Name = "ВидыПравилДляОбменаДанными", Comment = "", Synonym = "Виды правил для обмена данными")]
    public class ВидыПравилДляОбменаДанными:EnumItem
    {
        public static readonly ВидыПравилДляОбменаДанными ПравилаКонвертацииОбъектов = new ВидыПравилДляОбменаДанными{Name= "ПравилаКонвертацииОбъектов",Synonym="Правила конвертации объектов",Comment=""};
        public static readonly ВидыПравилДляОбменаДанными ПравилаРегистрацииОбъектов = new ВидыПравилДляОбменаДанными{Name= "ПравилаРегистрацииОбъектов",Synonym="Правила регистрации объектов",Comment=""};
    }
}

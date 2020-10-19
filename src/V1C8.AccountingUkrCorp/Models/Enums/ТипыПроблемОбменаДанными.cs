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
    [Table("TypyProblemObmenaDannymy")]
    [Description1C8(Name = "ТипыПроблемОбменаДанными", Comment = "", Synonym = "Типы проблем обмена данными")]
    public class ТипыПроблемОбменаДанными:EnumItem
    {
        public static readonly ТипыПроблемОбменаДанными НепроведенныйДокумент = new ТипыПроблемОбменаДанными{Name= "НепроведенныйДокумент",Synonym="Непроведенный документ",Comment=""};
        public static readonly ТипыПроблемОбменаДанными НезаполненныеРеквизиты = new ТипыПроблемОбменаДанными{Name= "НезаполненныеРеквизиты",Synonym="Незаполненные реквизиты",Comment=""};
    }
}

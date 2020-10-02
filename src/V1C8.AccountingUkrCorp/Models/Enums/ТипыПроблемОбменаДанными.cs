using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПроблемОбменаДанными", Comment = "", Synonym = "Типы проблем обмена данными")]
    public class ТипыПроблемОбменаДанными:EnumItem
    {
        public static readonly ТипыПроблемОбменаДанными НепроведенныйДокумент = new ТипыПроблемОбменаДанными{Name= "НепроведенныйДокумент",Synonim="Непроведенный документ",Comment=""};
        public static readonly ТипыПроблемОбменаДанными НезаполненныеРеквизиты = new ТипыПроблемОбменаДанными{Name= "НезаполненныеРеквизиты",Synonim="Незаполненные реквизиты",Comment=""};
    }
}

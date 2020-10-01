using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПроблемОбменаДанными", Comment = "", Synonym = "Типы проблем обмена данными")]
    public enum ТипыПроблемОбменаДанными
    {
        [Description1C8(Name = "НепроведенныйДокумент", Comment = "", Synonym = "Непроведенный документ")]
        НепроведенныйДокумент,
        [Description1C8(Name = "НезаполненныеРеквизиты", Comment = "", Synonym = "Незаполненные реквизиты")]
        НезаполненныеРеквизиты
    }
}

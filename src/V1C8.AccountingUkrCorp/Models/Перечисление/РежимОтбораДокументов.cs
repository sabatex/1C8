using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимОтбораДокументов", Comment = "", Synonym = "Режим отбора документов")]
    public enum РежимОтбораДокументов
    {
        [Description1C8(Name = "ПоРеквизитам", Comment = "", Synonym = "По реквизитам")]
        ПоРеквизитам,
        [Description1C8(Name = "ПоОборотам", Comment = "", Synonym = "По оборотам")]
        ПоОборотам,
        [Description1C8(Name = "ПоОстаткам", Comment = "", Synonym = "По остаткам")]
        ПоОстаткам
    }
}

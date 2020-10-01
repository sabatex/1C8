using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыИспользованияВнешнихКомпонент", Comment = "", Synonym = "Варианты использования внешних компонент")]
    public enum ВариантыИспользованияВнешнихКомпонент
    {
        [Description1C8(Name = "Используется", Comment = "", Synonym = "Используется")]
        Используется,
        [Description1C8(Name = "Отключена", Comment = "", Synonym = "Отключена")]
        Отключена
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыИспользованияВнешнихКомпонент", Comment = "", Synonym = "Варианты использования внешних компонент")]
    public class ВариантыИспользованияВнешнихКомпонент:EnumItem
    {
        public static readonly ВариантыИспользованияВнешнихКомпонент Используется = new ВариантыИспользованияВнешнихКомпонент{Name= "Используется",Synonim="Используется",Comment=""};
        public static readonly ВариантыИспользованияВнешнихКомпонент Отключена = new ВариантыИспользованияВнешнихКомпонент{Name= "Отключена",Synonim="Отключена",Comment=""};
    }
}

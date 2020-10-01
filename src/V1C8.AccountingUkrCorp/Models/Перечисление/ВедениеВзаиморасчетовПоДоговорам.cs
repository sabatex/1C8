using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВедениеВзаиморасчетовПоДоговорам", Comment = "(Общ)", Synonym = "Ведение взаиморасчетов по договорам")]
    public enum ВедениеВзаиморасчетовПоДоговорам
    {
        [Description1C8(Name = "ПоДоговоруВЦелом", Comment = "(Общ)", Synonym = "По договору в целом")]
        ПоДоговоруВЦелом,
        [Description1C8(Name = "ПоРасчетнымДокументам", Comment = "(Общ)", Synonym = "По документам расчетов")]
        ПоРасчетнымДокументам
    }
}

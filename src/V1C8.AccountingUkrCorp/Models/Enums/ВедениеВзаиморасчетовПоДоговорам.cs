using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВедениеВзаиморасчетовПоДоговорам", Comment = "(Общ)", Synonym = "Ведение взаиморасчетов по договорам")]
    public class ВедениеВзаиморасчетовПоДоговорам:EnumItem
    {
        public static readonly ВедениеВзаиморасчетовПоДоговорам ПоДоговоруВЦелом = new ВедениеВзаиморасчетовПоДоговорам{Name= "ПоДоговоруВЦелом",Synonim="По договору в целом",Comment="(Общ)"};
        public static readonly ВедениеВзаиморасчетовПоДоговорам ПоРасчетнымДокументам = new ВедениеВзаиморасчетовПоДоговорам{Name= "ПоРасчетнымДокументам",Synonim="По документам расчетов",Comment="(Общ)"};
    }
}

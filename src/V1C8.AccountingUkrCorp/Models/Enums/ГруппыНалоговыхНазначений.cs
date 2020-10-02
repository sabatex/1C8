using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыНалоговыхНазначений", Comment = "", Synonym = "Группы налоговых назначений")]
    public class ГруппыНалоговыхНазначений:EnumItem
    {
        public static readonly ГруппыНалоговыхНазначений НалоговыеНазначенияДоНКУ = new ГруппыНалоговыхНазначений{Name= "НалоговыеНазначенияДоНКУ",Synonim="до 01.04.2011 (устаревшие)",Comment=""};
        public static readonly ГруппыНалоговыхНазначений НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС = new ГруппыНалоговыхНазначений{Name= "НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС",Synonim="Активов и взаиморасчетов по НДС",Comment=""};
        public static readonly ГруппыНалоговыхНазначений НалоговыеНазначенияДоходовИЗатрат = new ГруппыНалоговыхНазначений{Name= "НалоговыеНазначенияДоходовИЗатрат",Synonim="до 01.01.2015 (устаревшие): Доходов и затрат",Comment=""};
    }
}

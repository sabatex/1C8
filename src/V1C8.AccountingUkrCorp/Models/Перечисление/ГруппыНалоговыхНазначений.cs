using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыНалоговыхНазначений", Comment = "", Synonym = "Группы налоговых назначений")]
    public enum ГруппыНалоговыхНазначений
    {
        [Description1C8(Name = "НалоговыеНазначенияДоНКУ", Comment = "", Synonym = "до 01.04.2011 (устаревшие)")]
        НалоговыеНазначенияДоНКУ,
        [Description1C8(Name = "НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС", Comment = "", Synonym = "Активов и взаиморасчетов по НДС")]
        НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС,
        [Description1C8(Name = "НалоговыеНазначенияДоходовИЗатрат", Comment = "", Synonym = "до 01.01.2015 (устаревшие): Доходов и затрат")]
        НалоговыеНазначенияДоходовИЗатрат
    }
}

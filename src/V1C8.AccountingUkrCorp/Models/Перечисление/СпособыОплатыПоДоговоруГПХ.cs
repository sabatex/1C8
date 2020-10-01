using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОплатыПоДоговоруГПХ", Comment = "", Synonym = "Способы оплаты по договору ГПХ")]
    public enum СпособыОплатыПоДоговоруГПХ
    {
        [Description1C8(Name = "ОднократноВКонцеСрока", Comment = "", Synonym = "Однократно в конце срока")]
        ОднократноВКонцеСрока,
        [Description1C8(Name = "ПоАктамВыполненныхРабот", Comment = "", Synonym = "По актам выполненных работ")]
        ПоАктамВыполненныхРабот,
        [Description1C8(Name = "ВКонцеСрокаСАвансовымиПлатежами", Comment = "", Synonym = "В конце срока с ежемесячными авансовыми платежами")]
        ВКонцеСрокаСАвансовымиПлатежами
    }
}

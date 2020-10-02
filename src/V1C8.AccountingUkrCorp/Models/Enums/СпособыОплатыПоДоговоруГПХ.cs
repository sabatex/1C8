using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОплатыПоДоговоруГПХ", Comment = "", Synonym = "Способы оплаты по договору ГПХ")]
    public class СпособыОплатыПоДоговоруГПХ:EnumItem
    {
        public static readonly СпособыОплатыПоДоговоруГПХ ОднократноВКонцеСрока = new СпособыОплатыПоДоговоруГПХ{Name= "ОднократноВКонцеСрока",Synonim="Однократно в конце срока",Comment=""};
        public static readonly СпособыОплатыПоДоговоруГПХ ПоАктамВыполненныхРабот = new СпособыОплатыПоДоговоруГПХ{Name= "ПоАктамВыполненныхРабот",Synonim="По актам выполненных работ",Comment=""};
        public static readonly СпособыОплатыПоДоговоруГПХ ВКонцеСрокаСАвансовымиПлатежами = new СпособыОплатыПоДоговоруГПХ{Name= "ВКонцеСрокаСАвансовымиПлатежами",Synonim="В конце срока с ежемесячными авансовыми платежами",Comment=""};
    }
}

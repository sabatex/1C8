using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("SposobyOplatyPoDohovoruHPKH")]
    [Description1C8(Name = "СпособыОплатыПоДоговоруГПХ", Comment = "", Synonym = "Способы оплаты по договору ГПХ")]
    public class СпособыОплатыПоДоговоруГПХ:EnumItem
    {
        public static readonly СпособыОплатыПоДоговоруГПХ ОднократноВКонцеСрока = new СпособыОплатыПоДоговоруГПХ{Name= "ОднократноВКонцеСрока",Synonym="Однократно в конце срока",Comment=""};
        public static readonly СпособыОплатыПоДоговоруГПХ ПоАктамВыполненныхРабот = new СпособыОплатыПоДоговоруГПХ{Name= "ПоАктамВыполненныхРабот",Synonym="По актам выполненных работ",Comment=""};
        public static readonly СпособыОплатыПоДоговоруГПХ ВКонцеСрокаСАвансовымиПлатежами = new СпособыОплатыПоДоговоруГПХ{Name= "ВКонцеСрокаСАвансовымиПлатежами",Synonym="В конце срока с ежемесячными авансовыми платежами",Comment=""};
    }
}

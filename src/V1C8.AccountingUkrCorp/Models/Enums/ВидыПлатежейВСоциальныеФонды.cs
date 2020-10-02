using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПлатежейВСоциальныеФонды", Comment = "", Synonym = "Виды платежей в социальные фонды")]
    public class ВидыПлатежейВСоциальныеФонды:EnumItem
    {
        public static readonly ВидыПлатежейВСоциальныеФонды Взносы = new ВидыПлатежейВСоциальныеФонды{Name= "Взносы",Synonim="Взносы: начислено / уплачено / зачтено",Comment=""};
        public static readonly ВидыПлатежейВСоциальныеФонды Пени = new ВидыПлатежейВСоциальныеФонды{Name= "Пени",Synonim="Пени: начислено / уплачено",Comment=""};
        public static readonly ВидыПлатежейВСоциальныеФонды Штрафы = new ВидыПлатежейВСоциальныеФонды{Name= "Штрафы",Synonim="Штрафы: начислено / уплачено",Comment=""};
    }
}

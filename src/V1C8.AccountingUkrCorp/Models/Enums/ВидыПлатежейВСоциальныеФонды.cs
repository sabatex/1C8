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
    [Table("VydyPlatezheiVSotsyalnyeFondy")]
    [Description1C8(Name = "ВидыПлатежейВСоциальныеФонды", Comment = "", Synonym = "Виды платежей в социальные фонды")]
    public class ВидыПлатежейВСоциальныеФонды:EnumItem
    {
        public static readonly ВидыПлатежейВСоциальныеФонды Взносы = new ВидыПлатежейВСоциальныеФонды{Name= "Взносы",Synonym="Взносы: начислено / уплачено / зачтено",Comment=""};
        public static readonly ВидыПлатежейВСоциальныеФонды Пени = new ВидыПлатежейВСоциальныеФонды{Name= "Пени",Synonym="Пени: начислено / уплачено",Comment=""};
        public static readonly ВидыПлатежейВСоциальныеФонды Штрафы = new ВидыПлатежейВСоциальныеФонды{Name= "Штрафы",Synonym="Штрафы: начислено / уплачено",Comment=""};
    }
}

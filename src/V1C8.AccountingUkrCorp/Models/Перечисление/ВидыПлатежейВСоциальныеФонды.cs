using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПлатежейВСоциальныеФонды", Comment = "", Synonym = "Виды платежей в социальные фонды")]
    public enum ВидыПлатежейВСоциальныеФонды
    {
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы: начислено / уплачено / зачтено")]
        Взносы,
        [Description1C8(Name = "Пени", Comment = "", Synonym = "Пени: начислено / уплачено")]
        Пени,
        [Description1C8(Name = "Штрафы", Comment = "", Synonym = "Штрафы: начислено / уплачено")]
        Штрафы
    }
}

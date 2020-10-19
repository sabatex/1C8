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
    [Table("PredstavlenyeTaryfovYNadbavok")]
    [Description1C8(Name = "ПредставлениеТарифовИНадбавок", Comment = "", Synonym = "Представление тарифов и надбавок")]
    public class ПредставлениеТарифовИНадбавок:EnumItem
    {
        public static readonly ПредставлениеТарифовИНадбавок МесячныйРазмерВГривнах = new ПредставлениеТарифовИНадбавок{Name= "МесячныйРазмерВГривнах",Synonym="Месячный размер в гривнах",Comment=""};
        public static readonly ПредставлениеТарифовИНадбавок ТарифыКоэффициенты = new ПредставлениеТарифовИНадбавок{Name= "ТарифыКоэффициенты",Synonym="Тариф, %, коэфф. и т.д.",Comment=""};
        public static readonly ПредставлениеТарифовИНадбавок МесячныйРазмерВГривнахИТарифыКоэффициенты = new ПредставлениеТарифовИНадбавок{Name= "МесячныйРазмерВГривнахИТарифыКоэффициенты",Synonym="Месячный размер и тариф, %, коэфф",Comment=""};
    }
}

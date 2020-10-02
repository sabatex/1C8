using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПредставлениеТарифовИНадбавок", Comment = "", Synonym = "Представление тарифов и надбавок")]
    public class ПредставлениеТарифовИНадбавок:EnumItem
    {
        public static readonly ПредставлениеТарифовИНадбавок МесячныйРазмерВГривнах = new ПредставлениеТарифовИНадбавок{Name= "МесячныйРазмерВГривнах",Synonim="Месячный размер в гривнах",Comment=""};
        public static readonly ПредставлениеТарифовИНадбавок ТарифыКоэффициенты = new ПредставлениеТарифовИНадбавок{Name= "ТарифыКоэффициенты",Synonim="Тариф, %, коэфф. и т.д.",Comment=""};
        public static readonly ПредставлениеТарифовИНадбавок МесячныйРазмерВГривнахИТарифыКоэффициенты = new ПредставлениеТарифовИНадбавок{Name= "МесячныйРазмерВГривнахИТарифыКоэффициенты",Synonim="Месячный размер и тариф, %, коэфф",Comment=""};
    }
}

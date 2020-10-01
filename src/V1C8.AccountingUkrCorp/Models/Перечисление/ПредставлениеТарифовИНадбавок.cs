using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПредставлениеТарифовИНадбавок", Comment = "", Synonym = "Представление тарифов и надбавок")]
    public enum ПредставлениеТарифовИНадбавок
    {
        [Description1C8(Name = "МесячныйРазмерВГривнах", Comment = "", Synonym = "Месячный размер в гривнах")]
        МесячныйРазмерВГривнах,
        [Description1C8(Name = "ТарифыКоэффициенты", Comment = "", Synonym = "Тариф, %, коэфф. и т.д.")]
        ТарифыКоэффициенты,
        [Description1C8(Name = "МесячныйРазмерВГривнахИТарифыКоэффициенты", Comment = "", Synonym = "Месячный размер и тариф, %, коэфф")]
        МесячныйРазмерВГривнахИТарифыКоэффициенты
    }
}

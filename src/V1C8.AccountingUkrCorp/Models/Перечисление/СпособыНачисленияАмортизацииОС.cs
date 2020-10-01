using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыНачисленияАмортизацииОС", Comment = "(Общ)", Synonym = "Способы начисления амортизации основных средств")]
    public enum СпособыНачисленияАмортизацииОС
    {
        [Description1C8(Name = "Прямолинейный", Comment = "", Synonym = "Прямолинейный")]
        Прямолинейный,
        [Description1C8(Name = "Налоговый", Comment = "", Synonym = "Налоговый (с 01.04.2011 не актуален)")]
        Налоговый,
        [Description1C8(Name = "УменьшенияОстатка", Comment = "", Synonym = "Уменьшения остатка")]
        УменьшенияОстатка,
        [Description1C8(Name = "Кумулятивный", Comment = "", Synonym = "Кумулятивный (по сумме чисел лет)")]
        Кумулятивный,
        [Description1C8(Name = "Производственный", Comment = "Пропорционально объему продукции", Synonym = "Производственный")]
        Производственный,
        [Description1C8(Name = "УскоренногоУменьшенияОстатка", Comment = "", Synonym = "Ускоренного уменьшения остатка")]
        УскоренногоУменьшенияОстатка,
        [Description1C8(Name = "_100", Comment = "100% в первый месяц эксплуатации", Synonym = "100%")]
        _100,
        [Description1C8(Name = "_50_50", Comment = "50% в первый месяц эксплуатации, 50% при списании", Synonym = "50% - 50%")]
        _50_50
    }
}

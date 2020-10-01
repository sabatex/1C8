using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыНачисленияАмортизацииНМА", Comment = "(Общ)", Synonym = "Способы начисления амортизации нематериальных активов")]
    public enum СпособыНачисленияАмортизацииНМА
    {
        [Description1C8(Name = "Прямолинейный", Comment = "(Общ)", Synonym = "Прямолинейный")]
        Прямолинейный,
        [Description1C8(Name = "УменьшенияОстатка", Comment = "(Общ)", Synonym = "Уменьшения остатка")]
        УменьшенияОстатка,
        [Description1C8(Name = "Производственный", Comment = "Пропорционально объему продукции", Synonym = "Производственный")]
        Производственный,
        [Description1C8(Name = "Кумулятивный", Comment = "", Synonym = "Кумулятивный (по сумме чисел лет)")]
        Кумулятивный,
        [Description1C8(Name = "УскоренногоУменьшенияОстатка", Comment = "", Synonym = "Ускоренного уменьшения остатка")]
        УскоренногоУменьшенияОстатка
    }
}

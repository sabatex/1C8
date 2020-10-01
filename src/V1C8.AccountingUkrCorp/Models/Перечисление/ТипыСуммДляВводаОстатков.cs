using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСуммДляВводаОстатков", Comment = "", Synonym = "Типы сумм для ввода остатков")]
    public enum ТипыСуммДляВводаОстатков
    {
        [Description1C8(Name = "Оборот", Comment = "", Synonym = "Оборот")]
        Оборот,
        [Description1C8(Name = "ОстатокНаНачало", Comment = "", Synonym = "Остаток на начало")]
        ОстатокНаНачало
    }
}

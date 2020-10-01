using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУлучшения", Comment = "", Synonym = "Виды улучшения")]
    public enum ВидыУлучшения
    {
        [Description1C8(Name = "Модернизация", Comment = "", Synonym = "Модернизация")]
        Модернизация,
        [Description1C8(Name = "Ремонт", Comment = "", Synonym = "Ремонт")]
        Ремонт
    }
}

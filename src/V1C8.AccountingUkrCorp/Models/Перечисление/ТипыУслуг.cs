using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыУслуг", Comment = "", Synonym = "Типы услуг")]
    public enum ТипыУслуг
    {
        [Description1C8(Name = "Безлимитная", Comment = "", Synonym = "Безлимитная")]
        Безлимитная,
        [Description1C8(Name = "Лимитированная", Comment = "", Synonym = "Лимитированная")]
        Лимитированная,
        [Description1C8(Name = "Уникальная", Comment = "", Synonym = "Уникальная")]
        Уникальная
    }
}

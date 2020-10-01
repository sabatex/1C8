using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыИспользованияИнформационнойБазы", Comment = "", Synonym = "Режимы использования информационной базы")]
    public enum РежимыИспользованияИнформационнойБазы
    {
        [Description1C8(Name = "Рабочий", Comment = "", Synonym = "Рабочий")]
        Рабочий,
        [Description1C8(Name = "Демонстрационный", Comment = "", Synonym = "Демонстрационный")]
        Демонстрационный
    }
}

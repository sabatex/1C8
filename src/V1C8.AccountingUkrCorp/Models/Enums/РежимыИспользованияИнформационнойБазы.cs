using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыИспользованияИнформационнойБазы", Comment = "", Synonym = "Режимы использования информационной базы")]
    public class РежимыИспользованияИнформационнойБазы:EnumItem
    {
        public static readonly РежимыИспользованияИнформационнойБазы Рабочий = new РежимыИспользованияИнформационнойБазы{Name= "Рабочий",Synonym="Рабочий",Comment=""};
        public static readonly РежимыИспользованияИнформационнойБазы Демонстрационный = new РежимыИспользованияИнформационнойБазы{Name= "Демонстрационный",Synonym="Демонстрационный",Comment=""};
    }
}

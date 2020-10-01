using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок", Comment = "", Synonym = "Режимы совместимости разрешений дополнительных отчетов и обработок")]
    public enum РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок
    {
        [Description1C8(Name = "Версия_2_1_3", Comment = "", Synonym = "Версия 2.1.3")]
        Версия_2_1_3,
        [Description1C8(Name = "Версия_2_2_2", Comment = "", Synonym = "Версия 2.2.2")]
        Версия_2_2_2
    }
}

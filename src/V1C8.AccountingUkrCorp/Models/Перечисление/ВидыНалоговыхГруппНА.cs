using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНалоговыхГруппНА", Comment = "", Synonym = "Виды налоговых групп НА")]
    public enum ВидыНалоговыхГруппНА
    {
        [Description1C8(Name = "ДоНКУ", Comment = "", Synonym = "до 01.04.2011 (устаревшие)")]
        ДоНКУ,
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        ОС,
        [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
        НМА
    }
}

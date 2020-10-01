using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПравилаОкругленияПриРасчетеЗарплаты", Comment = "", Synonym = "Правила округления (для целей расчета зарплаты)")]
    public enum ПравилаОкругленияПриРасчетеЗарплаты
    {
        [Description1C8(Name = "Авто", Comment = "", Synonym = "Авто")]
        Авто,
        [Description1C8(Name = "ВМеньшуюСторону", Comment = "", Synonym = "В сторону уменьшения")]
        ВМеньшуюСторону,
        [Description1C8(Name = "ВБольшуюСторону", Comment = "", Synonym = "В сторону увеличения")]
        ВБольшуюСторону
    }
}

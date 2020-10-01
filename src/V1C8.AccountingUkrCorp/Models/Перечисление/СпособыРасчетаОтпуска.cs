using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаОтпуска", Comment = "", Synonym = "Способы расчета отпуска")]
    public enum СпособыРасчетаОтпуска
    {
        [Description1C8(Name = "ВКалендарныхДнях", Comment = "", Synonym = "В календарных днях")]
        ВКалендарныхДнях,
        [Description1C8(Name = "ВРабочихДнях", Comment = "", Synonym = "В рабочих днях")]
        ВРабочихДнях,
        [Description1C8(Name = "ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора", Comment = "", Synonym = "В календарных или рабочих днях в зависимости от трудового договора")]
        ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора,
        [Description1C8(Name = "ВКалендарныхДняхСПраздниками", Comment = "", Synonym = "В календарных днях с праздниками")]
        ВКалендарныхДняхСПраздниками
    }
}

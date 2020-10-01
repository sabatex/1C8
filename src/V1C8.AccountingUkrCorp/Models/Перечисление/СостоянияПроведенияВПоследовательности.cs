using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияПроведенияВПоследовательности", Comment = "", Synonym = "Состояния проведения в последовательности")]
    public enum СостоянияПроведенияВПоследовательности
    {
        [Description1C8(Name = "ПроведенВПоследовательности", Comment = "", Synonym = "Проведен в последовательности")]
        ПроведенВПоследовательности,
        [Description1C8(Name = "ПроведенСНарушениемПоследовательности", Comment = "", Synonym = "Проведен с нарушением последовательности")]
        ПроведенСНарушениемПоследовательности,
        [Description1C8(Name = "ИсключенИзПоследовательности", Comment = "", Synonym = "Исключен из последовательности")]
        ИсключенИзПоследовательности
    }
}

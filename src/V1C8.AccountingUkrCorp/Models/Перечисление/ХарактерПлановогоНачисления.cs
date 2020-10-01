using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерПлановогоНачисления", Comment = "", Synonym = "Характер планового начисления")]
    public enum ХарактерПлановогоНачисления
    {
        [Description1C8(Name = "Штатное", Comment = "", Synonym = "Штатное")]
        Штатное,
        [Description1C8(Name = "Индивидуальное", Comment = "", Synonym = "Индивидуальное")]
        Индивидуальное
    }
}

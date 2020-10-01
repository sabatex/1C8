using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РасчетыВозврат", Comment = "(Общ)", Synonym = "Расчеты возврат")]
    public enum РасчетыВозврат
    {
        [Description1C8(Name = "Расчеты", Comment = "", Synonym = "Расчеты")]
        Расчеты,
        [Description1C8(Name = "Возврат", Comment = "", Synonym = "Возврат")]
        Возврат
    }
}

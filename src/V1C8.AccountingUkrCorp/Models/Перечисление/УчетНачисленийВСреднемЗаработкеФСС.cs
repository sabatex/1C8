using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеФСС", Comment = "", Synonym = "Учет начислений в среднем заработке ФСС")]
    public enum УчетНачисленийВСреднемЗаработкеФСС
    {
        [Description1C8(Name = "Включать", Comment = "", Synonym = "Включать")]
        Включать,
        [Description1C8(Name = "НеВключать", Comment = "", Synonym = "Не включать")]
        НеВключать
    }
}

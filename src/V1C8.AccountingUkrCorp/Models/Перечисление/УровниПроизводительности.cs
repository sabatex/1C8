using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УровниПроизводительности", Comment = "", Synonym = "Уровни производительности")]
    public enum УровниПроизводительности
    {
        [Description1C8(Name = "Идеально", Comment = "", Synonym = "Идеально (apdex = 1)")]
        Идеально,
        [Description1C8(Name = "Отлично", Comment = "", Synonym = "Отлично (apdex >= 0.94)")]
        Отлично,
        [Description1C8(Name = "Хорошо", Comment = "", Synonym = "Хорошо (apdex >= 0.85)")]
        Хорошо,
        [Description1C8(Name = "Удовлетворительно", Comment = "", Synonym = "Удовлетворительно (apdex >= 0.70)")]
        Удовлетворительно,
        [Description1C8(Name = "Плохо", Comment = "", Synonym = "Плохо (apdex >= 0.50)")]
        Плохо
    }
}

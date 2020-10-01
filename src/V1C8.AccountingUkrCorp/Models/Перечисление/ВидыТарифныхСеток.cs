using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТарифныхСеток", Comment = "", Synonym = "Виды тарифных сеток")]
    public enum ВидыТарифныхСеток
    {
        [Description1C8(Name = "Тариф", Comment = "", Synonym = "Тариф")]
        Тариф,
        [Description1C8(Name = "Надбавка", Comment = "", Synonym = "Надбавка")]
        Надбавка
    }
}

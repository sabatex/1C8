using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОплат", Comment = "", Synonym = "Типы оплат")]
    public enum ТипыОплат
    {
        [Description1C8(Name = "Наличные", Comment = "", Synonym = "Наличные")]
        Наличные,
        [Description1C8(Name = "ПлатежнаяКарта", Comment = "", Synonym = "Платежная карта")]
        ПлатежнаяКарта,
        [Description1C8(Name = "БанковскийКредит", Comment = "", Synonym = "Банковский кредит")]
        БанковскийКредит
    }
}

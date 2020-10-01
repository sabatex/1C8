using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПолейРегистра", Comment = "", Synonym = "Типы полей регистра")]
    public enum ТипыПолейРегистра
    {
        [Description1C8(Name = "Измерение", Comment = "", Synonym = "Измерение")]
        Измерение,
        [Description1C8(Name = "Ресурс", Comment = "", Synonym = "Ресурс")]
        Ресурс,
        [Description1C8(Name = "Реквизит", Comment = "", Synonym = "Реквизит")]
        Реквизит
    }
}

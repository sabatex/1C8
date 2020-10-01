using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДеятельностиНДС", Comment = "", Synonym = "Виды деятельности НДС")]
    public enum ВидыДеятельностиНДС
    {
        [Description1C8(Name = "Облагаемая", Comment = "", Synonym = "Облагаемая")]
        Облагаемая,
        [Description1C8(Name = "Необлагаемая", Comment = "", Synonym = "Необлагаемая")]
        Необлагаемая,
        [Description1C8(Name = "ПропорциональноОблагаемая", Comment = "", Synonym = "Пропорционально облагаемая")]
        ПропорциональноОблагаемая
    }
}

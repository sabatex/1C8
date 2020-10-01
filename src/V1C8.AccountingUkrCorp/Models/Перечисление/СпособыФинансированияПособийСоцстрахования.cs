using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыФинансированияПособийСоцстрахования", Comment = "", Synonym = "Способы финансирования пособий соцстрахования")]
    public enum СпособыФинансированияПособийСоцстрахования
    {
        [Description1C8(Name = "ЗаСчетФСС", Comment = "", Synonym = "За счет ФСС")]
        ЗаСчетФСС,
        [Description1C8(Name = "ЗаСчетРаботодателя", Comment = "", Synonym = "За счет работодателя")]
        ЗаСчетРаботодателя
    }
}

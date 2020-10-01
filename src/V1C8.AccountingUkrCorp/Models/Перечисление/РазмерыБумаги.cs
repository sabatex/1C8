using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазмерыБумаги", Comment = "", Synonym = "Размеры бумаги")]
    public enum РазмерыБумаги
    {
        [Description1C8(Name = "НеЗадано", Comment = "", Synonym = "Не задано")]
        НеЗадано,
        [Description1C8(Name = "A3", Comment = "", Synonym = "A3")]
        A3,
        [Description1C8(Name = "A4", Comment = "", Synonym = "A4")]
        A4,
        [Description1C8(Name = "A5", Comment = "", Synonym = "A5")]
        A5,
        [Description1C8(Name = "B4", Comment = "", Synonym = "B4")]
        B4,
        [Description1C8(Name = "B5", Comment = "", Synonym = "B5")]
        B5,
        [Description1C8(Name = "B6", Comment = "", Synonym = "B6")]
        B6,
        [Description1C8(Name = "C4", Comment = "", Synonym = "C4")]
        C4,
        [Description1C8(Name = "C5", Comment = "", Synonym = "C5")]
        C5,
        [Description1C8(Name = "C6", Comment = "", Synonym = "C6")]
        C6,
        [Description1C8(Name = "USExecutive", Comment = "", Synonym = "US Executive")]
        USExecutive,
        [Description1C8(Name = "USLegal", Comment = "", Synonym = "US Legal")]
        USLegal,
        [Description1C8(Name = "USLetter", Comment = "", Synonym = "US Letter")]
        USLetter
    }
}

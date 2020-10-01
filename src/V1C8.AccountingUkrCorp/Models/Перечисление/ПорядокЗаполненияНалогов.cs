using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокЗаполненияНалогов", Comment = "", Synonym = "Порядок заполнения налогов")]
    public enum ПорядокЗаполненияНалогов
    {
        [Description1C8(Name = "БезНалогов", Comment = "", Synonym = "Без налогов")]
        БезНалогов,
        [Description1C8(Name = "НДФЛИВзносы", Comment = "", Synonym = "НДФЛ и взносы")]
        НДФЛИВзносы,
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        НДФЛ,
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        Взносы
    }
}

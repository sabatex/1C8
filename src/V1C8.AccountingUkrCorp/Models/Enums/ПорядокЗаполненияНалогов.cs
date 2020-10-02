using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокЗаполненияНалогов", Comment = "", Synonym = "Порядок заполнения налогов")]
    public class ПорядокЗаполненияНалогов:EnumItem
    {
        public static readonly ПорядокЗаполненияНалогов БезНалогов = new ПорядокЗаполненияНалогов{Name= "БезНалогов",Synonym="Без налогов",Comment=""};
        public static readonly ПорядокЗаполненияНалогов НДФЛИВзносы = new ПорядокЗаполненияНалогов{Name= "НДФЛИВзносы",Synonym="НДФЛ и взносы",Comment=""};
        public static readonly ПорядокЗаполненияНалогов НДФЛ = new ПорядокЗаполненияНалогов{Name= "НДФЛ",Synonym="НДФЛ",Comment=""};
        public static readonly ПорядокЗаполненияНалогов Взносы = new ПорядокЗаполненияНалогов{Name= "Взносы",Synonym="Взносы",Comment=""};
    }
}

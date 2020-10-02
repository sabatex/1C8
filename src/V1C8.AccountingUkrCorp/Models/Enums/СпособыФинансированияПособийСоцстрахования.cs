using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыФинансированияПособийСоцстрахования", Comment = "", Synonym = "Способы финансирования пособий соцстрахования")]
    public class СпособыФинансированияПособийСоцстрахования:EnumItem
    {
        public static readonly СпособыФинансированияПособийСоцстрахования ЗаСчетФСС = new СпособыФинансированияПособийСоцстрахования{Name= "ЗаСчетФСС",Synonym="За счет ФСС",Comment=""};
        public static readonly СпособыФинансированияПособийСоцстрахования ЗаСчетРаботодателя = new СпособыФинансированияПособийСоцстрахования{Name= "ЗаСчетРаботодателя",Synonym="За счет работодателя",Comment=""};
    }
}

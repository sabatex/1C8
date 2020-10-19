using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("TsvetnostyYzobrazhenyia")]
    [Description1C8(Name = "ЦветностиИзображения", Comment = "", Synonym = "Цветности изображения")]
    public class ЦветностиИзображения:EnumItem
    {
        public static readonly ЦветностиИзображения Монохромное = new ЦветностиИзображения{Name= "Монохромное",Synonym="Монохромное",Comment=""};
        public static readonly ЦветностиИзображения ГрадацииСерого = new ЦветностиИзображения{Name= "ГрадацииСерого",Synonym="Градации серого",Comment=""};
        public static readonly ЦветностиИзображения Цветное = new ЦветностиИзображения{Name= "Цветное",Synonym="Цветное",Comment=""};
    }
}

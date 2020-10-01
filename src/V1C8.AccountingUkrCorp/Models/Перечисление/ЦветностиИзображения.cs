using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЦветностиИзображения", Comment = "", Synonym = "Цветности изображения")]
    public enum ЦветностиИзображения
    {
        [Description1C8(Name = "Монохромное", Comment = "", Synonym = "Монохромное")]
        Монохромное,
        [Description1C8(Name = "ГрадацииСерого", Comment = "", Synonym = "Градации серого")]
        ГрадацииСерого,
        [Description1C8(Name = "Цветное", Comment = "", Synonym = "Цветное")]
        Цветное
    }
}

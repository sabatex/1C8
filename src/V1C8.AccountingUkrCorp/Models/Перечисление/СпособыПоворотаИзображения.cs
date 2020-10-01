using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПоворотаИзображения", Comment = "", Synonym = "Способы поворота изображения")]
    public enum СпособыПоворотаИзображения
    {
        [Description1C8(Name = "НетПоворота", Comment = "", Synonym = "Нет поворота")]
        НетПоворота,
        [Description1C8(Name = "ВправоНа90", Comment = "", Synonym = "Вправо на 90")]
        ВправоНа90,
        [Description1C8(Name = "ВправоНа180", Comment = "", Synonym = "Вправо на 180")]
        ВправоНа180,
        [Description1C8(Name = "ВлевоНа90", Comment = "", Synonym = "Влево на 90")]
        ВлевоНа90
    }
}

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
    [Table("VydyUluchshenyia")]
    [Description1C8(Name = "ВидыУлучшения", Comment = "", Synonym = "Виды улучшения")]
    public class ВидыУлучшения:EnumItem
    {
        public static readonly ВидыУлучшения Модернизация = new ВидыУлучшения{Name= "Модернизация",Synonym="Модернизация",Comment=""};
        public static readonly ВидыУлучшения Ремонт = new ВидыУлучшения{Name= "Ремонт",Synonym="Ремонт",Comment=""};
    }
}

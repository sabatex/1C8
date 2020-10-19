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
    [Table("VydyPredelovDokhodovNDFL")]
    [Description1C8(Name = "ВидыПределовДоходовНДФЛ", Comment = "", Synonym = "Виды пределов доходов НДФЛ")]
    public class ВидыПределовДоходовНДФЛ:EnumItem
    {
        public static readonly ВидыПределовДоходовНДФЛ Годовой = new ВидыПределовДоходовНДФЛ{Name= "Годовой",Synonym="Годовой",Comment=""};
        public static readonly ВидыПределовДоходовНДФЛ Разовый = new ВидыПределовДоходовНДФЛ{Name= "Разовый",Synonym="Разовый",Comment=""};
    }
}

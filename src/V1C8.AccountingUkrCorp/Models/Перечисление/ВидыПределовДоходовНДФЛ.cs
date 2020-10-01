using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПределовДоходовНДФЛ", Comment = "", Synonym = "Виды пределов доходов НДФЛ")]
    public enum ВидыПределовДоходовНДФЛ
    {
        [Description1C8(Name = "Годовой", Comment = "", Synonym = "Годовой")]
        Годовой,
        [Description1C8(Name = "Разовый", Comment = "", Synonym = "Разовый")]
        Разовый
    }
}

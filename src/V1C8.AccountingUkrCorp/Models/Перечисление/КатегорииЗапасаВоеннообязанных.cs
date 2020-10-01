using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииЗапасаВоеннообязанных", Comment = "", Synonym = "Категории запаса военнообязанных")]
    public enum КатегорииЗапасаВоеннообязанных
    {
        [Description1C8(Name = "ПерваяКатегория", Comment = "", Synonym = "1")]
        ПерваяКатегория,
        [Description1C8(Name = "ВтораяКатегория", Comment = "", Synonym = "2")]
        ВтораяКатегория
    }
}

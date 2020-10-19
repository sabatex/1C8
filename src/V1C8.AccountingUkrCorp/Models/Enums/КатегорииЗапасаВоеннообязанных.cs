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
    [Table("KatehoryyZapasaVoennoobiazannykh")]
    [Description1C8(Name = "КатегорииЗапасаВоеннообязанных", Comment = "", Synonym = "Категории запаса военнообязанных")]
    public class КатегорииЗапасаВоеннообязанных:EnumItem
    {
        public static readonly КатегорииЗапасаВоеннообязанных ПерваяКатегория = new КатегорииЗапасаВоеннообязанных{Name= "ПерваяКатегория",Synonym="1",Comment=""};
        public static readonly КатегорииЗапасаВоеннообязанных ВтораяКатегория = new КатегорииЗапасаВоеннообязанных{Name= "ВтораяКатегория",Synonym="2",Comment=""};
    }
}

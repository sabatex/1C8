using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТарифыМобильногоБанка", Comment = "", Synonym = "Тарифы мобильного банка")]
    public class ТарифыМобильногоБанка:EnumItem
    {
        public static readonly ТарифыМобильногоБанка Экономный = new ТарифыМобильногоБанка{Name= "Экономный",Synonym="Экономный",Comment=""};
        public static readonly ТарифыМобильногоБанка Полный = new ТарифыМобильногоБанка{Name= "Полный",Synonym="Полный",Comment=""};
    }
}

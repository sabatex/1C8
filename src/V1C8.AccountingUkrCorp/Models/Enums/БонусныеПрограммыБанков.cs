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
    [Table("BonusnyeProhrammyBankov")]
    [Description1C8(Name = "БонусныеПрограммыБанков", Comment = "", Synonym = "Бонусные программы банков")]
    public class БонусныеПрограммыБанков:EnumItem
    {
        public static readonly БонусныеПрограммыБанков AE = new БонусныеПрограммыБанков{Name= "AE",Synonym="Аэрофлот бонус",Comment=""};
        public static readonly БонусныеПрограммыБанков GM = new БонусныеПрограммыБанков{Name= "GM",Synonym="Золотая маска",Comment=""};
        public static readonly БонусныеПрограммыБанков PG = new БонусныеПрограммыБанков{Name= "PG",Synonym="Подари жизнь",Comment=""};
    }
}

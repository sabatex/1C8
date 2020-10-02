using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "БонусныеПрограммыБанков", Comment = "", Synonym = "Бонусные программы банков")]
    public class БонусныеПрограммыБанков:EnumItem
    {
        public static readonly БонусныеПрограммыБанков AE = new БонусныеПрограммыБанков{Name= "AE",Synonim="Аэрофлот бонус",Comment=""};
        public static readonly БонусныеПрограммыБанков GM = new БонусныеПрограммыБанков{Name= "GM",Synonim="Золотая маска",Comment=""};
        public static readonly БонусныеПрограммыБанков PG = new БонусныеПрограммыБанков{Name= "PG",Synonim="Подари жизнь",Comment=""};
    }
}

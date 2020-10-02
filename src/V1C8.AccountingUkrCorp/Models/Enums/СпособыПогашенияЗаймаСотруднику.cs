using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПогашенияЗаймаСотруднику", Comment = "", Synonym = "Способы погашения займа сотруднику")]
    public class СпособыПогашенияЗаймаСотруднику:EnumItem
    {
        public static readonly СпособыПогашенияЗаймаСотруднику ВТечениеСрока = new СпособыПогашенияЗаймаСотруднику{Name= "ВТечениеСрока",Synonim="В течение срока",Comment=""};
        public static readonly СпособыПогашенияЗаймаСотруднику ПоОкончанииСрока = new СпособыПогашенияЗаймаСотруднику{Name= "ПоОкончанииСрока",Synonim="По окончании срока",Comment=""};
    }
}

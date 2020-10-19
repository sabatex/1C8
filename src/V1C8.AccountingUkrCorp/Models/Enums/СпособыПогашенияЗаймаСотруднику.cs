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
    [Table("SposobyPohashenyiaZaimaSotrudnyku")]
    [Description1C8(Name = "СпособыПогашенияЗаймаСотруднику", Comment = "", Synonym = "Способы погашения займа сотруднику")]
    public class СпособыПогашенияЗаймаСотруднику:EnumItem
    {
        public static readonly СпособыПогашенияЗаймаСотруднику ВТечениеСрока = new СпособыПогашенияЗаймаСотруднику{Name= "ВТечениеСрока",Synonym="В течение срока",Comment=""};
        public static readonly СпособыПогашенияЗаймаСотруднику ПоОкончанииСрока = new СпособыПогашенияЗаймаСотруднику{Name= "ПоОкончанииСрока",Synonym="По окончании срока",Comment=""};
    }
}

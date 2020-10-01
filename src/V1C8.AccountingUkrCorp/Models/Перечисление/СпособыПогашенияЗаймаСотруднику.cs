using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПогашенияЗаймаСотруднику", Comment = "", Synonym = "Способы погашения займа сотруднику")]
    public enum СпособыПогашенияЗаймаСотруднику
    {
        [Description1C8(Name = "ВТечениеСрока", Comment = "", Synonym = "В течение срока")]
        ВТечениеСрока,
        [Description1C8(Name = "ПоОкончанииСрока", Comment = "", Synonym = "По окончании срока")]
        ПоОкончанииСрока
    }
}

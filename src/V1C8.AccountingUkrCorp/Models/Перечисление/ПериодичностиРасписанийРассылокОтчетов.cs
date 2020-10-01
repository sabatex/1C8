using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодичностиРасписанийРассылокОтчетов", Comment = "", Synonym = "Периодичности расписаний рассылок отчетов")]
    public enum ПериодичностиРасписанийРассылокОтчетов
    {
        [Description1C8(Name = "Ежедневно", Comment = "", Synonym = "Ежедневно")]
        Ежедневно,
        [Description1C8(Name = "Еженедельно", Comment = "", Synonym = "Еженедельно")]
        Еженедельно,
        [Description1C8(Name = "Ежемесячно", Comment = "", Synonym = "Ежемесячно")]
        Ежемесячно,
        [Description1C8(Name = "Произвольное", Comment = "", Synonym = "Произвольное")]
        Произвольное
    }
}

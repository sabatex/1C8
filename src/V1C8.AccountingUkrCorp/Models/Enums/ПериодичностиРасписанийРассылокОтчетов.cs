using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодичностиРасписанийРассылокОтчетов", Comment = "", Synonym = "Периодичности расписаний рассылок отчетов")]
    public class ПериодичностиРасписанийРассылокОтчетов:EnumItem
    {
        public static readonly ПериодичностиРасписанийРассылокОтчетов Ежедневно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Ежедневно",Synonim="Ежедневно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Еженедельно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Еженедельно",Synonim="Еженедельно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Ежемесячно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Ежемесячно",Synonim="Ежемесячно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Произвольное = new ПериодичностиРасписанийРассылокОтчетов{Name= "Произвольное",Synonim="Произвольное",Comment=""};
    }
}

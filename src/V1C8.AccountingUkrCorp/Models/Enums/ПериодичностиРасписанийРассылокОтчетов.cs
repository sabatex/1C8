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
    [Table("PeryodychnostyRaspysanyiRassylokOtchetov")]
    [Description1C8(Name = "ПериодичностиРасписанийРассылокОтчетов", Comment = "", Synonym = "Периодичности расписаний рассылок отчетов")]
    public class ПериодичностиРасписанийРассылокОтчетов:EnumItem
    {
        public static readonly ПериодичностиРасписанийРассылокОтчетов Ежедневно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Ежедневно",Synonym="Ежедневно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Еженедельно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Еженедельно",Synonym="Еженедельно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Ежемесячно = new ПериодичностиРасписанийРассылокОтчетов{Name= "Ежемесячно",Synonym="Ежемесячно",Comment=""};
        public static readonly ПериодичностиРасписанийРассылокОтчетов Произвольное = new ПериодичностиРасписанийРассылокОтчетов{Name= "Произвольное",Synonym="Произвольное",Comment=""};
    }
}

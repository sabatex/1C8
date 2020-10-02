using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыЛистковСообщения", Comment = "", Synonym = "Статусы листков сообщения")]
    public class СтатусыЛистковСообщения:EnumItem
    {
        public static readonly СтатусыЛистковСообщения НеВрученСотруднику = new СтатусыЛистковСообщения{Name= "НеВрученСотруднику",Synonim="Не вручен сотруднику",Comment=""};
        public static readonly СтатусыЛистковСообщения ВрученСотруднику = new СтатусыЛистковСообщения{Name= "ВрученСотруднику",Synonim="Вручен сотруднику",Comment=""};
        public static readonly СтатусыЛистковСообщения ПредъявленКорешок = new СтатусыЛистковСообщения{Name= "ПредъявленКорешок",Synonim="Предъявлен корешок из военкомата",Comment=""};
    }
}

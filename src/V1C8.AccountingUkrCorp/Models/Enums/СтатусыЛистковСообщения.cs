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
    [Table("StatusyLystkovSoobshchenyia")]
    [Description1C8(Name = "СтатусыЛистковСообщения", Comment = "", Synonym = "Статусы листков сообщения")]
    public class СтатусыЛистковСообщения:EnumItem
    {
        public static readonly СтатусыЛистковСообщения НеВрученСотруднику = new СтатусыЛистковСообщения{Name= "НеВрученСотруднику",Synonym="Не вручен сотруднику",Comment=""};
        public static readonly СтатусыЛистковСообщения ВрученСотруднику = new СтатусыЛистковСообщения{Name= "ВрученСотруднику",Synonym="Вручен сотруднику",Comment=""};
        public static readonly СтатусыЛистковСообщения ПредъявленКорешок = new СтатусыЛистковСообщения{Name= "ПредъявленКорешок",Synonym="Предъявлен корешок из военкомата",Comment=""};
    }
}

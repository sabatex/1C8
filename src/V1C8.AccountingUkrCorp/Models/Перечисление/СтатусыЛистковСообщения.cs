using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыЛистковСообщения", Comment = "", Synonym = "Статусы листков сообщения")]
    public enum СтатусыЛистковСообщения
    {
        [Description1C8(Name = "НеВрученСотруднику", Comment = "", Synonym = "Не вручен сотруднику")]
        НеВрученСотруднику,
        [Description1C8(Name = "ВрученСотруднику", Comment = "", Synonym = "Вручен сотруднику")]
        ВрученСотруднику,
        [Description1C8(Name = "ПредъявленКорешок", Comment = "", Synonym = "Предъявлен корешок из военкомата")]
        ПредъявленКорешок
    }
}

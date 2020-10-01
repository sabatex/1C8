using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыДоставкиКорреспонденцииБанка", Comment = "", Synonym = "Способы доставки корреспонденции банка")]
    public enum СпособыДоставкиКорреспонденцииБанка
    {
        [Description1C8(Name = "НеРассылать", Comment = "", Synonym = "Не рассылать")]
        НеРассылать,
        [Description1C8(Name = "Email", Comment = "", Synonym = "E-mail")]
        Email,
        [Description1C8(Name = "Почтой", Comment = "", Synonym = "Почтой")]
        Почтой
    }
}

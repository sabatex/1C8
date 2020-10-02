using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыДоставкиКорреспонденцииБанка", Comment = "", Synonym = "Способы доставки корреспонденции банка")]
    public class СпособыДоставкиКорреспонденцииБанка:EnumItem
    {
        public static readonly СпособыДоставкиКорреспонденцииБанка НеРассылать = new СпособыДоставкиКорреспонденцииБанка{Name= "НеРассылать",Synonym="Не рассылать",Comment=""};
        public static readonly СпособыДоставкиКорреспонденцииБанка Email = new СпособыДоставкиКорреспонденцииБанка{Name= "Email",Synonym="E-mail",Comment=""};
        public static readonly СпособыДоставкиКорреспонденцииБанка Почтой = new СпособыДоставкиКорреспонденцииБанка{Name= "Почтой",Synonym="Почтой",Comment=""};
    }
}

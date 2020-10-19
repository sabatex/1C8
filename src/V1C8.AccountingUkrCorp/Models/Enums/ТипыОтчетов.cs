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
    [Table("TypyOtchetov")]
    [Description1C8(Name = "ТипыОтчетов", Comment = "", Synonym = "Типы отчетов")]
    public class ТипыОтчетов:EnumItem
    {
        public static readonly ТипыОтчетов Внутренний = new ТипыОтчетов{Name= "Внутренний",Synonym="Внутренний",Comment=""};
        public static readonly ТипыОтчетов Дополнительный = new ТипыОтчетов{Name= "Дополнительный",Synonym="Дополнительный",Comment=""};
        public static readonly ТипыОтчетов Расширение = new ТипыОтчетов{Name= "Расширение",Synonym="Расширение",Comment=""};
        public static readonly ТипыОтчетов Внешний = new ТипыОтчетов{Name= "Внешний",Synonym="Внешний",Comment=""};
        public static readonly ТипыОтчетов УдалитьОтчет = new ТипыОтчетов{Name= "УдалитьОтчет",Synonym="(не используется) Отчет",Comment=""};
        public static readonly ТипыОтчетов УдалитьПользовательский = new ТипыОтчетов{Name= "УдалитьПользовательский",Synonym="(не используется) Пользовательский",Comment=""};
    }
}

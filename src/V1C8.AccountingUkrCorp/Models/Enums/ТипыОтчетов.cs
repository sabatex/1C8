using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОтчетов", Comment = "", Synonym = "Типы отчетов")]
    public class ТипыОтчетов:EnumItem
    {
        public static readonly ТипыОтчетов Внутренний = new ТипыОтчетов{Name= "Внутренний",Synonim="Внутренний",Comment=""};
        public static readonly ТипыОтчетов Дополнительный = new ТипыОтчетов{Name= "Дополнительный",Synonim="Дополнительный",Comment=""};
        public static readonly ТипыОтчетов Расширение = new ТипыОтчетов{Name= "Расширение",Synonim="Расширение",Comment=""};
        public static readonly ТипыОтчетов Внешний = new ТипыОтчетов{Name= "Внешний",Synonim="Внешний",Comment=""};
        public static readonly ТипыОтчетов УдалитьОтчет = new ТипыОтчетов{Name= "УдалитьОтчет",Synonim="(не используется) Отчет",Comment=""};
        public static readonly ТипыОтчетов УдалитьПользовательский = new ТипыОтчетов{Name= "УдалитьПользовательский",Synonim="(не используется) Пользовательский",Comment=""};
    }
}

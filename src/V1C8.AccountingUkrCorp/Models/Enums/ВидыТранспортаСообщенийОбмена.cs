using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТранспортаСообщенийОбмена", Comment = "", Synonym = "Виды транспорта сообщений обмена")]
    public class ВидыТранспортаСообщенийОбмена:EnumItem
    {
        public static readonly ВидыТранспортаСообщенийОбмена EMAIL = new ВидыТранспортаСообщенийОбмена{Name= "EMAIL",Synonim="Почтовые сообщения",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена FILE = new ВидыТранспортаСообщенийОбмена{Name= "FILE",Synonim="Локальный или сетевой каталог",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена FTP = new ВидыТранспортаСообщенийОбмена{Name= "FTP",Synonim="FTP-ресурс",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена WS = new ВидыТранспортаСообщенийОбмена{Name= "WS",Synonim="Интернет",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена COM = new ВидыТранспортаСообщенийОбмена{Name= "COM",Synonim="Прямое подключение",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена WSПассивныйРежим = new ВидыТранспортаСообщенийОбмена{Name= "WSПассивныйРежим",Synonim="Интернет (пассивный режим)",Comment=""};
    }
}

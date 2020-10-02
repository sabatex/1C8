using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТранспортаСообщенийОбмена", Comment = "", Synonym = "Виды транспорта сообщений обмена")]
    public class ВидыТранспортаСообщенийОбмена:EnumItem
    {
        public static readonly ВидыТранспортаСообщенийОбмена EMAIL = new ВидыТранспортаСообщенийОбмена{Name= "EMAIL",Synonym="Почтовые сообщения",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена FILE = new ВидыТранспортаСообщенийОбмена{Name= "FILE",Synonym="Локальный или сетевой каталог",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена FTP = new ВидыТранспортаСообщенийОбмена{Name= "FTP",Synonym="FTP-ресурс",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена WS = new ВидыТранспортаСообщенийОбмена{Name= "WS",Synonym="Интернет",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена COM = new ВидыТранспортаСообщенийОбмена{Name= "COM",Synonym="Прямое подключение",Comment=""};
        public static readonly ВидыТранспортаСообщенийОбмена WSПассивныйРежим = new ВидыТранспортаСообщенийОбмена{Name= "WSПассивныйРежим",Synonym="Интернет (пассивный режим)",Comment=""};
    }
}

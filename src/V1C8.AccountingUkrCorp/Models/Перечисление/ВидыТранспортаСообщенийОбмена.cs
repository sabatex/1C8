using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТранспортаСообщенийОбмена", Comment = "", Synonym = "Виды транспорта сообщений обмена")]
    public enum ВидыТранспортаСообщенийОбмена
    {
        [Description1C8(Name = "EMAIL", Comment = "", Synonym = "Почтовые сообщения")]
        EMAIL,
        [Description1C8(Name = "FILE", Comment = "", Synonym = "Локальный или сетевой каталог")]
        FILE,
        [Description1C8(Name = "FTP", Comment = "", Synonym = "FTP-ресурс")]
        FTP,
        [Description1C8(Name = "WS", Comment = "", Synonym = "Интернет")]
        WS,
        [Description1C8(Name = "COM", Comment = "", Synonym = "Прямое подключение")]
        COM,
        [Description1C8(Name = "WSПассивныйРежим", Comment = "", Synonym = "Интернет (пассивный режим)")]
        WSПассивныйРежим
    }
}

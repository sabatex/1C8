using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьТипыАвтоматическогоОбменаДанными", Comment = "", Synonym = "(не используется) Типы автоматического обмена данными")]
    public enum УдалитьТипыАвтоматическогоОбменаДанными
    {
        [Description1C8(Name = "ОбменЧерезФайловыйРесурс", Comment = "", Synonym = "Обмен через файловый ресурс")]
        ОбменЧерезФайловыйРесурс,
        [Description1C8(Name = "ОбменЧерезFTPРесурс", Comment = "", Synonym = "Обмен через FTP ресурс")]
        ОбменЧерезFTPРесурс,
        [Description1C8(Name = "ОбменЧерезПочту", Comment = "", Synonym = "Обмен электронными сообщениями")]
        ОбменЧерезПочту,
        [Description1C8(Name = "ОбменЧерезComСоединение", Comment = "", Synonym = "Обмен через подключение к информационной базе")]
        ОбменЧерезComСоединение
    }
}

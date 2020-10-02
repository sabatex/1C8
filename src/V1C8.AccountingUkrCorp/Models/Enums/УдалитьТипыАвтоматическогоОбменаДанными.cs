using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьТипыАвтоматическогоОбменаДанными", Comment = "", Synonym = "(не используется) Типы автоматического обмена данными")]
    public class УдалитьТипыАвтоматическогоОбменаДанными:EnumItem
    {
        public static readonly УдалитьТипыАвтоматическогоОбменаДанными ОбменЧерезФайловыйРесурс = new УдалитьТипыАвтоматическогоОбменаДанными{Name= "ОбменЧерезФайловыйРесурс",Synonim="Обмен через файловый ресурс",Comment=""};
        public static readonly УдалитьТипыАвтоматическогоОбменаДанными ОбменЧерезFTPРесурс = new УдалитьТипыАвтоматическогоОбменаДанными{Name= "ОбменЧерезFTPРесурс",Synonim="Обмен через FTP ресурс",Comment=""};
        public static readonly УдалитьТипыАвтоматическогоОбменаДанными ОбменЧерезПочту = new УдалитьТипыАвтоматическогоОбменаДанными{Name= "ОбменЧерезПочту",Synonim="Обмен электронными сообщениями",Comment=""};
        public static readonly УдалитьТипыАвтоматическогоОбменаДанными ОбменЧерезComСоединение = new УдалитьТипыАвтоматическогоОбменаДанными{Name= "ОбменЧерезComСоединение",Synonim="Обмен через подключение к информационной базе",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодировкаФайловОбменаПоЗарплатномуПроекту", Comment = "", Synonym = "Кодировка файлов обмена по зарплатному проекту")]
    public class КодировкаФайловОбменаПоЗарплатномуПроекту:EnumItem
    {
        public static readonly КодировкаФайловОбменаПоЗарплатномуПроекту UTF8 = new КодировкаФайловОбменаПоЗарплатномуПроекту{Name= "UTF8",Synonim="UTF-8",Comment=""};
        public static readonly КодировкаФайловОбменаПоЗарплатномуПроекту Windows1251 = new КодировкаФайловОбменаПоЗарплатномуПроекту{Name= "Windows1251",Synonim="windows-1251",Comment=""};
    }
}

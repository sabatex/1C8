using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодировкаФайловОбменаПоЗарплатномуПроекту", Comment = "", Synonym = "Кодировка файлов обмена по зарплатному проекту")]
    public enum КодировкаФайловОбменаПоЗарплатномуПроекту
    {
        [Description1C8(Name = "UTF8", Comment = "", Synonym = "UTF-8")]
        UTF8,
        [Description1C8(Name = "Windows1251", Comment = "", Synonym = "windows-1251")]
        Windows1251
    }
}

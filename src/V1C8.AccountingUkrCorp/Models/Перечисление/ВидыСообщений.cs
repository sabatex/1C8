using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСообщений", Comment = "", Synonym = "Виды сообщений")]
    public enum ВидыСообщений
    {
        [Description1C8(Name = "Раздел", Comment = "", Synonym = "Раздел")]
        Раздел,
        [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
        Информация,
        [Description1C8(Name = "ВажнаяИнформация", Comment = "", Synonym = "Важная информация")]
        ВажнаяИнформация,
        [Description1C8(Name = "Ошибка", Comment = "", Synonym = "Ошибка")]
        Ошибка
    }
}

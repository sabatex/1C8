using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыАутентификации", Comment = "", Synonym = "Способы аутентификации")]
    public enum СпособыАутентификации
    {
        [Description1C8(Name = "Анонимный", Comment = "", Synonym = "Анонимный (Anonymous)")]
        Анонимный,
        [Description1C8(Name = "ОбычнаяПроверка", Comment = "", Synonym = "Обычная проверка (Basic)")]
        ОбычнаяПроверка
    }
}

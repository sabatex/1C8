using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ИсточникиПравилДляОбменаДанными", Comment = "", Synonym = "Источники правил для обмена данными")]
    public enum ИсточникиПравилДляОбменаДанными
    {
        [Description1C8(Name = "МакетКонфигурации", Comment = "", Synonym = "Макет конфигурации")]
        МакетКонфигурации,
        [Description1C8(Name = "Файл", Comment = "", Synonym = "Файл")]
        Файл
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыОбластейДанных", Comment = "", Synonym = "Статусы областей данных")]
    public enum СтатусыОбластейДанных
    {
        [Description1C8(Name = "Новая", Comment = "", Synonym = "Новая")]
        Новая,
        [Description1C8(Name = "Используется", Comment = "", Synonym = "Используется")]
        Используется,
        [Description1C8(Name = "КУдалению", Comment = "", Synonym = "К удалению")]
        КУдалению,
        [Description1C8(Name = "Удалена", Comment = "", Synonym = "Удалена")]
        Удалена,
        [Description1C8(Name = "ИмпортИзФайла", Comment = "", Synonym = "Импорт из файла")]
        ИмпортИзФайла
    }
}

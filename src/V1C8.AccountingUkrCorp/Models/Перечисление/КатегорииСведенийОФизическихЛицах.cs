using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСведенийОФизическихЛицах", Comment = "", Synonym = "Категории сведений о физических лицах")]
    public enum КатегорииСведенийОФизическихЛицах
    {
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        Должность,
        [Description1C8(Name = "Инвалидность", Comment = "", Synonym = "Инвалидность")]
        Инвалидность,
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        КонтактнаяИнформация,
        [Description1C8(Name = "Образование", Comment = "", Synonym = "Образование")]
        Образование,
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        Организация,
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        Подразделение,
        [Description1C8(Name = "СемейноеПоложение", Comment = "", Synonym = "Семейное положение")]
        СемейноеПоложение,
        [Description1C8(Name = "СоставСемьи", Comment = "", Synonym = "Состав семьи")]
        СоставСемьи
    }
}

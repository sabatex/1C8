using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыИсполнительныхДокументов", Comment = "", Synonym = "Виды исполнительных документов")]
    public enum ВидыИсполнительныхДокументов
    {
        [Description1C8(Name = "ИсполнительныйЛист", Comment = "", Synonym = "Исполнительный лист")]
        ИсполнительныйЛист,
        [Description1C8(Name = "СоглашениеОбУплатеАлиментов", Comment = "", Synonym = "Соглашение об уплате алиментов")]
        СоглашениеОбУплатеАлиментов
    }
}

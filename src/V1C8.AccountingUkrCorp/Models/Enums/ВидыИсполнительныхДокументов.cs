using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыИсполнительныхДокументов", Comment = "", Synonym = "Виды исполнительных документов")]
    public class ВидыИсполнительныхДокументов:EnumItem
    {
        public static readonly ВидыИсполнительныхДокументов ИсполнительныйЛист = new ВидыИсполнительныхДокументов{Name= "ИсполнительныйЛист",Synonim="Исполнительный лист",Comment=""};
        public static readonly ВидыИсполнительныхДокументов СоглашениеОбУплатеАлиментов = new ВидыИсполнительныхДокументов{Name= "СоглашениеОбУплатеАлиментов",Synonim="Соглашение об уплате алиментов",Comment=""};
    }
}

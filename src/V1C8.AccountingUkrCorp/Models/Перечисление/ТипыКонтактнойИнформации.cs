using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыКонтактнойИнформации", Comment = "", Synonym = "Типы контактной информации")]
    public enum ТипыКонтактнойИнформации
    {
        [Description1C8(Name = "Адрес", Comment = "", Synonym = "Адрес")]
        Адрес,
        [Description1C8(Name = "Телефон", Comment = "", Synonym = "Телефон")]
        Телефон,
        [Description1C8(Name = "АдресЭлектроннойПочты", Comment = "", Synonym = "Адрес электронной почты")]
        АдресЭлектроннойПочты,
        [Description1C8(Name = "Skype", Comment = "", Synonym = "Skype")]
        Skype,
        [Description1C8(Name = "ВебСтраница", Comment = "", Synonym = "Веб страница")]
        ВебСтраница,
        [Description1C8(Name = "Факс", Comment = "", Synonym = "Факс")]
        Факс,
        [Description1C8(Name = "Другое", Comment = "", Synonym = "Другое")]
        Другое
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыSMTPАутентификации", Comment = "", Synonym = "Варианты SMTP аутентификации")]
    public enum ВариантыSMTPАутентификации
    {
        [Description1C8(Name = "АналогичноPOP3", Comment = "", Synonym = "Аналогично POP3")]
        АналогичноPOP3,
        [Description1C8(Name = "ЗадаетсяПараметрами", Comment = "", Synonym = "Задается параметрами")]
        ЗадаетсяПараметрами,
        [Description1C8(Name = "POP3ПередSMTP", Comment = "", Synonym = "POP3 перед SMTP")]
        POP3ПередSMTP,
        [Description1C8(Name = "НеЗадано", Comment = "", Synonym = "Не задано")]
        НеЗадано
    }
}

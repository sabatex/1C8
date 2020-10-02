using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыSMTPАутентификации", Comment = "", Synonym = "Варианты SMTP аутентификации")]
    public class ВариантыSMTPАутентификации:EnumItem
    {
        public static readonly ВариантыSMTPАутентификации АналогичноPOP3 = new ВариантыSMTPАутентификации{Name= "АналогичноPOP3",Synonym="Аналогично POP3",Comment=""};
        public static readonly ВариантыSMTPАутентификации ЗадаетсяПараметрами = new ВариантыSMTPАутентификации{Name= "ЗадаетсяПараметрами",Synonym="Задается параметрами",Comment=""};
        public static readonly ВариантыSMTPАутентификации POP3ПередSMTP = new ВариантыSMTPАутентификации{Name= "POP3ПередSMTP",Synonym="POP3 перед SMTP",Comment=""};
        public static readonly ВариантыSMTPАутентификации НеЗадано = new ВариантыSMTPАутентификации{Name= "НеЗадано",Synonym="Не задано",Comment=""};
    }
}

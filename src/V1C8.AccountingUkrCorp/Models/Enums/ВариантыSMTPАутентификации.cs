using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыSMTPАутентификации", Comment = "", Synonym = "Варианты SMTP аутентификации")]
    public class ВариантыSMTPАутентификации:EnumItem
    {
        public static readonly ВариантыSMTPАутентификации АналогичноPOP3 = new ВариантыSMTPАутентификации{Name= "АналогичноPOP3",Synonim="Аналогично POP3",Comment=""};
        public static readonly ВариантыSMTPАутентификации ЗадаетсяПараметрами = new ВариантыSMTPАутентификации{Name= "ЗадаетсяПараметрами",Synonim="Задается параметрами",Comment=""};
        public static readonly ВариантыSMTPАутентификации POP3ПередSMTP = new ВариантыSMTPАутентификации{Name= "POP3ПередSMTP",Synonim="POP3 перед SMTP",Comment=""};
        public static readonly ВариантыSMTPАутентификации НеЗадано = new ВариантыSMTPАутентификации{Name= "НеЗадано",Synonim="Не задано",Comment=""};
    }
}

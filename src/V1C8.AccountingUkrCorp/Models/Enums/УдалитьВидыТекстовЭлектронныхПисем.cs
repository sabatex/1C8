using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыТекстовЭлектронныхПисем", Comment = "", Synonym = "(не используется) Виды текстов электронных писем")]
    public class УдалитьВидыТекстовЭлектронныхПисем:EnumItem
    {
        public static readonly УдалитьВидыТекстовЭлектронныхПисем HTML = new УдалитьВидыТекстовЭлектронныхПисем{Name= "HTML",Synonim="HTML",Comment=""};
        public static readonly УдалитьВидыТекстовЭлектронныхПисем Текст = new УдалитьВидыТекстовЭлектронныхПисем{Name= "Текст",Synonim="Простой текст",Comment=""};
        public static readonly УдалитьВидыТекстовЭлектронныхПисем Прочее = new УдалитьВидыТекстовЭлектронныхПисем{Name= "Прочее",Synonim="Прочее",Comment=""};
        public static readonly УдалитьВидыТекстовЭлектронныхПисем HTMLСКартинками = new УдалитьВидыТекстовЭлектронныхПисем{Name= "HTMLСКартинками",Synonim="HTML с картинками",Comment=""};
    }
}

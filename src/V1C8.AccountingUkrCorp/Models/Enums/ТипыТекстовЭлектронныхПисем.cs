using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыТекстовЭлектронныхПисем", Comment = "", Synonym = "Типы текстов электронных писем")]
    public class ТипыТекстовЭлектронныхПисем:EnumItem
    {
        public static readonly ТипыТекстовЭлектронныхПисем HTML = new ТипыТекстовЭлектронныхПисем{Name= "HTML",Synonim="HTML",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем ПростойТекст = new ТипыТекстовЭлектронныхПисем{Name= "ПростойТекст",Synonim="Простой текст",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем РазмеченныйТекст = new ТипыТекстовЭлектронныхПисем{Name= "РазмеченныйТекст",Synonim="Размеченный текст",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем HTMLСКартинками = new ТипыТекстовЭлектронныхПисем{Name= "HTMLСКартинками",Synonim="HTML с картинками",Comment=""};
    }
}

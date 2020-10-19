using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("TypyTekstovЕlektronnykhPysem")]
    [Description1C8(Name = "ТипыТекстовЭлектронныхПисем", Comment = "", Synonym = "Типы текстов электронных писем")]
    public class ТипыТекстовЭлектронныхПисем:EnumItem
    {
        public static readonly ТипыТекстовЭлектронныхПисем HTML = new ТипыТекстовЭлектронныхПисем{Name= "HTML",Synonym="HTML",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем ПростойТекст = new ТипыТекстовЭлектронныхПисем{Name= "ПростойТекст",Synonym="Простой текст",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем РазмеченныйТекст = new ТипыТекстовЭлектронныхПисем{Name= "РазмеченныйТекст",Synonym="Размеченный текст",Comment=""};
        public static readonly ТипыТекстовЭлектронныхПисем HTMLСКартинками = new ТипыТекстовЭлектронныхПисем{Name= "HTMLСКартинками",Synonym="HTML с картинками",Comment=""};
    }
}

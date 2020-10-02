using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "Нумераторы", Comment = "", Synonym = "Нумераторы")]
    public class Нумераторы:EnumItem
    {
        public static readonly Нумераторы ПлатежноеПоручение = new Нумераторы{Name= "ПлатежноеПоручение",Synonym="Платежное поручение",Comment=""};
        public static readonly Нумераторы РасходныйКассовыйОрдер = new Нумераторы{Name= "РасходныйКассовыйОрдер",Synonym="Расходный кассовый ордер",Comment=""};
        public static readonly Нумераторы ПриходныйКассовыйОрдер = new Нумераторы{Name= "ПриходныйКассовыйОрдер",Synonym="Приходный кассовый ордер",Comment=""};
    }
}

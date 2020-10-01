using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "Нумераторы", Comment = "", Synonym = "Нумераторы")]
    public enum Нумераторы
    {
        [Description1C8(Name = "ПлатежноеПоручение", Comment = "", Synonym = "Платежное поручение")]
        ПлатежноеПоручение,
        [Description1C8(Name = "РасходныйКассовыйОрдер", Comment = "", Synonym = "Расходный кассовый ордер")]
        РасходныйКассовыйОрдер,
        [Description1C8(Name = "ПриходныйКассовыйОрдер", Comment = "", Synonym = "Приходный кассовый ордер")]
        ПриходныйКассовыйОрдер
    }
}

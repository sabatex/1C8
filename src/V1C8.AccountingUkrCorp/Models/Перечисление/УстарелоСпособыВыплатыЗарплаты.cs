using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоСпособыВыплатыЗарплаты", Comment = "(Регл)", Synonym = "Устарело способы выплаты зарплаты")]
    public enum УстарелоСпособыВыплатыЗарплаты
    {
        [Description1C8(Name = "ЧерезКассу", Comment = "", Synonym = "Через кассу")]
        ЧерезКассу,
        [Description1C8(Name = "ЧерезБанк", Comment = "", Synonym = "Через банк")]
        ЧерезБанк
    }
}

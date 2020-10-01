using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВыплаченностьЗарплаты", Comment = "(Регл)", Synonym = "Устарело выплаченность зарплаты")]
    public enum УстарелоВыплаченностьЗарплаты
    {
        [Description1C8(Name = "НеВыплачено", Comment = "", Synonym = "Не выплачено")]
        НеВыплачено,
        [Description1C8(Name = "Выплачено", Comment = "", Synonym = "Выплачено")]
        Выплачено,
        [Description1C8(Name = "Задепонировано", Comment = "", Synonym = "Задепонировано")]
        Задепонировано
    }
}

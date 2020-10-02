using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВыплаченностьЗарплаты", Comment = "(Регл)", Synonym = "Устарело выплаченность зарплаты")]
    public class УстарелоВыплаченностьЗарплаты:EnumItem
    {
        public static readonly УстарелоВыплаченностьЗарплаты НеВыплачено = new УстарелоВыплаченностьЗарплаты{Name= "НеВыплачено",Synonim="Не выплачено",Comment=""};
        public static readonly УстарелоВыплаченностьЗарплаты Выплачено = new УстарелоВыплаченностьЗарплаты{Name= "Выплачено",Synonim="Выплачено",Comment=""};
        public static readonly УстарелоВыплаченностьЗарплаты Задепонировано = new УстарелоВыплаченностьЗарплаты{Name= "Задепонировано",Synonim="Задепонировано",Comment=""};
    }
}

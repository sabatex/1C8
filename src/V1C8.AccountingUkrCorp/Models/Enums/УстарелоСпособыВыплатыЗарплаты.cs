using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоСпособыВыплатыЗарплаты", Comment = "(Регл)", Synonym = "Устарело способы выплаты зарплаты")]
    public class УстарелоСпособыВыплатыЗарплаты:EnumItem
    {
        public static readonly УстарелоСпособыВыплатыЗарплаты ЧерезКассу = new УстарелоСпособыВыплатыЗарплаты{Name= "ЧерезКассу",Synonym="Через кассу",Comment=""};
        public static readonly УстарелоСпособыВыплатыЗарплаты ЧерезБанк = new УстарелоСпособыВыплатыЗарплаты{Name= "ЧерезБанк",Synonym="Через банк",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСотрудниковОбменаСБанками", Comment = "", Synonym = "Категории сотрудников обмена с банками")]
    public class КатегорииСотрудниковОбменаСБанками:EnumItem
    {
        public static readonly КатегорииСотрудниковОбменаСБанками Прочие = new КатегорииСотрудниковОбменаСБанками{Name= "Прочие",Synonim="Прочие",Comment=""};
        public static readonly КатегорииСотрудниковОбменаСБанками Пенсионеры = new КатегорииСотрудниковОбменаСБанками{Name= "Пенсионеры",Synonim="Пенсионеры",Comment=""};
        public static readonly КатегорииСотрудниковОбменаСБанками Студенты = new КатегорииСотрудниковОбменаСБанками{Name= "Студенты",Synonim="Студенты",Comment=""};
    }
}

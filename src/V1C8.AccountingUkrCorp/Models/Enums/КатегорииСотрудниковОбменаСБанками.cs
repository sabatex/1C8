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
    [Table("KatehoryySotrudnykovObmenaSBankamy")]
    [Description1C8(Name = "КатегорииСотрудниковОбменаСБанками", Comment = "", Synonym = "Категории сотрудников обмена с банками")]
    public class КатегорииСотрудниковОбменаСБанками:EnumItem
    {
        public static readonly КатегорииСотрудниковОбменаСБанками Прочие = new КатегорииСотрудниковОбменаСБанками{Name= "Прочие",Synonym="Прочие",Comment=""};
        public static readonly КатегорииСотрудниковОбменаСБанками Пенсионеры = new КатегорииСотрудниковОбменаСБанками{Name= "Пенсионеры",Synonym="Пенсионеры",Comment=""};
        public static readonly КатегорииСотрудниковОбменаСБанками Студенты = new КатегорииСотрудниковОбменаСБанками{Name= "Студенты",Synonym="Студенты",Comment=""};
    }
}

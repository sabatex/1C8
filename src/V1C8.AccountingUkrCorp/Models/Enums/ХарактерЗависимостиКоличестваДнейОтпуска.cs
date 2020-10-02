using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерЗависимостиКоличестваДнейОтпуска", Comment = "", Synonym = "Характер зависимости количества дней отпуска")]
    public class ХарактерЗависимостиКоличестваДнейОтпуска:EnumItem
    {
        public static readonly ХарактерЗависимостиКоличестваДнейОтпуска НеЗависит = new ХарактерЗависимостиКоличестваДнейОтпуска{Name= "НеЗависит",Synonim="Не зависит",Comment=""};
        public static readonly ХарактерЗависимостиКоличестваДнейОтпуска ЗависитОтРабочегоМеста = new ХарактерЗависимостиКоличестваДнейОтпуска{Name= "ЗависитОтРабочегоМеста",Synonim="Зависит от рабочего места",Comment=""};
        public static readonly ХарактерЗависимостиКоличестваДнейОтпуска ЗависитОтСтажа = new ХарактерЗависимостиКоличестваДнейОтпуска{Name= "ЗависитОтСтажа",Synonim="Зависит от стажа",Comment=""};
    }
}

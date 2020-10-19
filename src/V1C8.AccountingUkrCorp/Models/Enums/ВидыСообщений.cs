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
    [Table("VydySoobshchenyi")]
    [Description1C8(Name = "ВидыСообщений", Comment = "", Synonym = "Виды сообщений")]
    public class ВидыСообщений:EnumItem
    {
        public static readonly ВидыСообщений Раздел = new ВидыСообщений{Name= "Раздел",Synonym="Раздел",Comment=""};
        public static readonly ВидыСообщений Информация = new ВидыСообщений{Name= "Информация",Synonym="Информация",Comment=""};
        public static readonly ВидыСообщений ВажнаяИнформация = new ВидыСообщений{Name= "ВажнаяИнформация",Synonym="Важная информация",Comment=""};
        public static readonly ВидыСообщений Ошибка = new ВидыСообщений{Name= "Ошибка",Synonym="Ошибка",Comment=""};
    }
}

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
    [Table("SostoianyiaZaprosovNaYspolzovanyeVneshnykhResursov")]
    [Description1C8(Name = "СостоянияЗапросовНаИспользованиеВнешнихРесурсов", Comment = "", Synonym = "Состояния запросов на использование внешних ресурсов")]
    public class СостоянияЗапросовНаИспользованиеВнешнихРесурсов:EnumItem
    {
        public static readonly СостоянияЗапросовНаИспользованиеВнешнихРесурсов Новый = new СостоянияЗапросовНаИспользованиеВнешнихРесурсов{Name= "Новый",Synonym="Новый",Comment=""};
        public static readonly СостоянияЗапросовНаИспользованиеВнешнихРесурсов Применен = new СостоянияЗапросовНаИспользованиеВнешнихРесурсов{Name= "Применен",Synonym="Применен",Comment=""};
        public static readonly СостоянияЗапросовНаИспользованиеВнешнихРесурсов Проверен = new СостоянияЗапросовНаИспользованиеВнешнихРесурсов{Name= "Проверен",Synonym="Проверен",Comment=""};
    }
}

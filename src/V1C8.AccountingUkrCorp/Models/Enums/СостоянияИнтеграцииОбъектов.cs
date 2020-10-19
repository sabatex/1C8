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
    [Table("SostoianyiaYntehratsyyObektov")]
    [Description1C8(Name = "СостоянияИнтеграцииОбъектов", Comment = "", Synonym = "Состояния интеграции объектов")]
    public class СостоянияИнтеграцииОбъектов:EnumItem
    {
        public static readonly СостоянияИнтеграцииОбъектов Ожидание = new СостоянияИнтеграцииОбъектов{Name= "Ожидание",Synonym="Ожидание",Comment=""};
        public static readonly СостоянияИнтеграцииОбъектов Интегрирован = new СостоянияИнтеграцииОбъектов{Name= "Интегрирован",Synonym="Интегрирован",Comment=""};
        public static readonly СостоянияИнтеграцииОбъектов Ошибка = new СостоянияИнтеграцииОбъектов{Name= "Ошибка",Synonym="Ошибка",Comment=""};
    }
}

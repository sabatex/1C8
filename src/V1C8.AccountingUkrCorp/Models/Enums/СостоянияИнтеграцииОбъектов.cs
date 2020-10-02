using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияИнтеграцииОбъектов", Comment = "", Synonym = "Состояния интеграции объектов")]
    public class СостоянияИнтеграцииОбъектов:EnumItem
    {
        public static readonly СостоянияИнтеграцииОбъектов Ожидание = new СостоянияИнтеграцииОбъектов{Name= "Ожидание",Synonim="Ожидание",Comment=""};
        public static readonly СостоянияИнтеграцииОбъектов Интегрирован = new СостоянияИнтеграцииОбъектов{Name= "Интегрирован",Synonim="Интегрирован",Comment=""};
        public static readonly СостоянияИнтеграцииОбъектов Ошибка = new СостоянияИнтеграцииОбъектов{Name= "Ошибка",Synonim="Ошибка",Comment=""};
    }
}

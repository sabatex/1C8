using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияПодключенияСервисов", Comment = "", Synonym = "Состояния подключения сервисов")]
    public class СостоянияПодключенияСервисов:EnumItem
    {
        public static readonly СостоянияПодключенияСервисов НеПодключен = new СостоянияПодключенияСервисов{Name= "НеПодключен",Synonym="Не подключен",Comment=""};
        public static readonly СостоянияПодключенияСервисов ОшибкаПодключения = new СостоянияПодключенияСервисов{Name= "ОшибкаПодключения",Synonym="Ошибка подключения",Comment=""};
        public static readonly СостоянияПодключенияСервисов Подключен = new СостоянияПодключенияСервисов{Name= "Подключен",Synonym="Подключен",Comment=""};
        public static readonly СостоянияПодключенияСервисов Подключение = new СостоянияПодключенияСервисов{Name= "Подключение",Synonym="Подключение",Comment=""};
        public static readonly СостоянияПодключенияСервисов ПодключениеНедоступно = new СостоянияПодключенияСервисов{Name= "ПодключениеНедоступно",Synonym="Подключение недоступно",Comment=""};
    }
}

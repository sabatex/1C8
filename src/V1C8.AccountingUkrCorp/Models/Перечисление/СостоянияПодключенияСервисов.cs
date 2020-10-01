using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияПодключенияСервисов", Comment = "", Synonym = "Состояния подключения сервисов")]
    public enum СостоянияПодключенияСервисов
    {
        [Description1C8(Name = "НеПодключен", Comment = "", Synonym = "Не подключен")]
        НеПодключен,
        [Description1C8(Name = "ОшибкаПодключения", Comment = "", Synonym = "Ошибка подключения")]
        ОшибкаПодключения,
        [Description1C8(Name = "Подключен", Comment = "", Synonym = "Подключен")]
        Подключен,
        [Description1C8(Name = "Подключение", Comment = "", Synonym = "Подключение")]
        Подключение,
        [Description1C8(Name = "ПодключениеНедоступно", Comment = "", Synonym = "Подключение недоступно")]
        ПодключениеНедоступно
    }
}

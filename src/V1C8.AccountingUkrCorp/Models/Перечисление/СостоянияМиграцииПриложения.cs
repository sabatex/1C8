using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияМиграцииПриложения", Comment = "", Synonym = "Состояния миграции приложения")]
    public enum СостоянияМиграцииПриложения
    {
        [Description1C8(Name = "Выполняется", Comment = "", Synonym = "Выполняется")]
        Выполняется,
        [Description1C8(Name = "ЗавершенаСОшибкой", Comment = "", Synonym = "Завершена с ошибкой")]
        ЗавершенаСОшибкой,
        [Description1C8(Name = "ЗавершенаУспешно", Comment = "", Synonym = "Завершена успешно")]
        ЗавершенаУспешно,
        [Description1C8(Name = "ОжиданиеЗагрузки", Comment = "", Synonym = "Ожидание загрузки")]
        ОжиданиеЗагрузки,
        [Description1C8(Name = "ОжиданиеОбновления", Comment = "", Synonym = "Ожидание обновления")]
        ОжиданиеОбновления
    }
}

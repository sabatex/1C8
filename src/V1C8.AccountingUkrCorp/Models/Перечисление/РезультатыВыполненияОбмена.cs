using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыВыполненияОбмена", Comment = "", Synonym = "Результаты выполнения обмена")]
    public enum РезультатыВыполненияОбмена
    {
        [Description1C8(Name = "Выполнено", Comment = "", Synonym = "Выполнено")]
        Выполнено,
        [Description1C8(Name = "Отменено", Comment = "", Synonym = "Отменено")]
        Отменено,
        [Description1C8(Name = "Ошибка", Comment = "", Synonym = "Ошибка")]
        Ошибка,
        [Description1C8(Name = "Ошибка_ТранспортСообщения", Comment = "", Synonym = "Ошибка транспорта сообщения")]
        Ошибка_ТранспортСообщения,
        [Description1C8(Name = "Предупреждение_СообщениеОбменаБылоРанееПринято", Comment = "", Synonym = "Сообщение обмена было ранее принято")]
        Предупреждение_СообщениеОбменаБылоРанееПринято,
        [Description1C8(Name = "ВыполненоСПредупреждениями", Comment = "", Synonym = "Выполнено с предупреждениями")]
        ВыполненоСПредупреждениями
    }
}

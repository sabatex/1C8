using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияЗаданий", Comment = "", Synonym = "Состояния заданий")]
    public enum СостоянияЗаданий
    {
        [Description1C8(Name = "Запланировано", Comment = "Задание запланировано на выполнение", Synonym = "Запланировано")]
        Запланировано,
        [Description1C8(Name = "Выполняется", Comment = "Задание выполняется", Synonym = "Выполняется")]
        Выполняется,
        [Description1C8(Name = "Завершено", Comment = "Задание завершено", Synonym = "Завершено")]
        Завершено,
        [Description1C8(Name = "НеЗапланировано", Comment = "Задание не запланировано", Synonym = "Не запланировано")]
        НеЗапланировано,
        [Description1C8(Name = "ОшибкаВыполнения", Comment = "Ошибка при выполнении задания", Synonym = "Ошибка выполнения")]
        ОшибкаВыполнения,
        [Description1C8(Name = "НеАктивно", Comment = "Задание не активно", Synonym = "Не активно")]
        НеАктивно,
        [Description1C8(Name = "ОбработкаОшибкиПриАварийномЗавершении", Comment = "", Synonym = "Обработка ошибки при аварийном завершении")]
        ОбработкаОшибкиПриАварийномЗавершении
    }
}

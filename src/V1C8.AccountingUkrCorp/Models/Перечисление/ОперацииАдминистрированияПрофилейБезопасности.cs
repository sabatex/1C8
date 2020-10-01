using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОперацииАдминистрированияПрофилейБезопасности", Comment = "", Synonym = "Операции администрирования профилей безопасности")]
    public enum ОперацииАдминистрированияПрофилейБезопасности
    {
        [Description1C8(Name = "Создание", Comment = "", Synonym = "Создание")]
        Создание,
        [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
        Назначение,
        [Description1C8(Name = "Обновление", Comment = "", Synonym = "Обновление")]
        Обновление,
        [Description1C8(Name = "Удаление", Comment = "", Synonym = "Удаление")]
        Удаление,
        [Description1C8(Name = "УдалениеНазначения", Comment = "", Synonym = "Удаление назначения")]
        УдалениеНазначения
    }
}

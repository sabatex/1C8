using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныОтключенияРасширенийВМоделиСервиса", Comment = "", Synonym = "Причины отключения расширений в модели сервиса")]
    public enum ПричиныОтключенияРасширенийВМоделиСервиса
    {
        [Description1C8(Name = "БлокировкаАдминистраторомСервиса", Comment = "", Synonym = "Блокировка администратором сервиса")]
        БлокировкаАдминистраторомСервиса,
        [Description1C8(Name = "БлокировкаВладельцем", Comment = "", Synonym = "Блокировка владельцем")]
        БлокировкаВладельцем,
        [Description1C8(Name = "ОбновлениеВерсииКонфигурации", Comment = "", Synonym = "Обновление версии конфигурации")]
        ОбновлениеВерсииКонфигурации
    }
}

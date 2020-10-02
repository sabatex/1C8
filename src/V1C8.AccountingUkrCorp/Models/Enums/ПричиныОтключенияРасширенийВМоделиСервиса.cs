using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныОтключенияРасширенийВМоделиСервиса", Comment = "", Synonym = "Причины отключения расширений в модели сервиса")]
    public class ПричиныОтключенияРасширенийВМоделиСервиса:EnumItem
    {
        public static readonly ПричиныОтключенияРасширенийВМоделиСервиса БлокировкаАдминистраторомСервиса = new ПричиныОтключенияРасширенийВМоделиСервиса{Name= "БлокировкаАдминистраторомСервиса",Synonim="Блокировка администратором сервиса",Comment=""};
        public static readonly ПричиныОтключенияРасширенийВМоделиСервиса БлокировкаВладельцем = new ПричиныОтключенияРасширенийВМоделиСервиса{Name= "БлокировкаВладельцем",Synonim="Блокировка владельцем",Comment=""};
        public static readonly ПричиныОтключенияРасширенийВМоделиСервиса ОбновлениеВерсииКонфигурации = new ПричиныОтключенияРасширенийВМоделиСервиса{Name= "ОбновлениеВерсииКонфигурации",Synonim="Обновление версии конфигурации",Comment=""};
    }
}

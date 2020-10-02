using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса", Comment = "", Synonym = "Причины отключения дополнительных отчетов и обработок в модели сервиса")]
    public class ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса:EnumItem
    {
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса БлокировкаАдминистраторомСервиса = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "БлокировкаАдминистраторомСервиса",Synonim="Блокировка администратором сервиса",Comment=""};
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса БлокировкаВладельцем = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "БлокировкаВладельцем",Synonim="Блокировка владельцем",Comment=""};
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса ОбновлениеВерсииКонфигурации = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "ОбновлениеВерсииКонфигурации",Synonim="Обновление версии конфигурации",Comment=""};
    }
}

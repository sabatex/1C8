using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("PrychynyOtkliuchenyiaDopolnytelnykhOtchetovYObrabotokVModelyServysa")]
    [Description1C8(Name = "ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса", Comment = "", Synonym = "Причины отключения дополнительных отчетов и обработок в модели сервиса")]
    public class ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса:EnumItem
    {
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса БлокировкаАдминистраторомСервиса = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "БлокировкаАдминистраторомСервиса",Synonym="Блокировка администратором сервиса",Comment=""};
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса БлокировкаВладельцем = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "БлокировкаВладельцем",Synonym="Блокировка владельцем",Comment=""};
        public static readonly ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса ОбновлениеВерсииКонфигурации = new ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса{Name= "ОбновлениеВерсииКонфигурации",Synonym="Обновление версии конфигурации",Comment=""};
    }
}

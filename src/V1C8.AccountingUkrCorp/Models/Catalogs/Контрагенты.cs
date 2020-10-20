using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("Kontrahenty")]
    [Description1C8(Name = "Контрагенты", Comment = "", Synonym = "Контрагенты")]
    public class Контрагенты:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
        [StringLength(250)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public bool ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "(Общ)", Synonym = "Юр. / физ. лицо")]
        public Enums.ЮридическоеФизическоеЛицо ЮридическоеФизическоеЛицо {get; set;}
        [Description1C8(Name = "ГоловнойКонтрагент", Comment = "(Общ)", Synonym = "Головной контрагент")]
        public Catalogs.Контрагенты ГоловнойКонтрагент {get; set;}
        [Description1C8(Name = "ИНН", Comment = "Идентификационный номер налогоплательщика", Synonym = "ИНН")]
        [StringLength(12)]
        public string ИНН {get; set;}
        [Description1C8(Name = "ДокументУдостоверяющийЛичность", Comment = "", Synonym = "Документ")]
        [StringLength(250)]
        public string ДокументУдостоверяющийЛичность {get; set;}
        [Description1C8(Name = "ОсновнойБанковскийСчет", Comment = "", Synonym = "Банковский счет")]
        public Catalogs.БанковскиеСчета ОсновнойБанковскийСчет {get; set;}
        [Description1C8(Name = "ОсновнойДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ОсновнойДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ОсновноеКонтактноеЛицо", Comment = "", Synonym = "Контактное лицо")]
        public Catalogs.КонтактныеЛица ОсновноеКонтактноеЛицо {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУ", Comment = "(Регл) Код по ЕДРПОУ", Synonym = "Код по ЕДРПОУ")]
        [StringLength(12)]
        public string КодПоЕДРПОУ {get; set;}
        [Description1C8(Name = "НомерСвидетельства", Comment = "Номер свидетельства плательщика НДС", Synonym = "Номер свидетельства")]
        [StringLength(12)]
        public string НомерСвидетельства {get; set;}
        [Description1C8(Name = "НеЯвляетсяРезидентом", Comment = "", Synonym = "Не является резидентом")]
        public bool НеЯвляетсяРезидентом {get; set;}
        [Description1C8(Name = "ДополнятьНаименованиеАдресДаннымиГоловногоКонтрагентаВНН", Comment = "", Synonym = "В налоговых накладных дополнять наименование и адрес данными головного контрагента")]
        public bool ДополнятьНаименованиеАдресДаннымиГоловногоКонтрагентаВНН {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ДополнительнаяИнформация", Comment = "", Synonym = "Дополнительная информация")]
        public string ДополнительнаяИнформация {get; set;}
        [Description1C8(Name = "КодФилиала", Comment = "", Synonym = "Код филиала (для отправки налоговых документов через FREDO Звіт)")]
        [StringLength(15)]
        public string КодФилиала {get; set;}
        [Description1C8(Name = "ИспользоватьЭДО1СЗвит", Comment = "", Synonym = "Использовать FREDO ДокМен")]
        public bool ИспользоватьЭДО1СЗвит {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<Контрагенты_КонтактнаяИнформация> КонтрагентыКонтактнаяИнформация {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Контрагенты_ДополнительныеРеквизиты> КонтрагентыДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "ИсторияКонтактнойИнформации", Comment = "", Synonym = "История контактной информации")]
        public List<Контрагенты_ИсторияКонтактнойИнформации> КонтрагентыИсторияКонтактнойИнформации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    [Table("Kontrahenty_KontaktnaiaYnformatsyia")]
    public class Контрагенты_КонтактнаяИнформация
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ТипыКонтактнойИнформации Тип {get; set;}
        [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
        public Catalogs.ВидыКонтактнойИнформации Вид {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представление")]
        [StringLength(500)]
        public string Представление {get; set;}
        [Description1C8(Name = "ЗначенияПолей", Comment = "", Synonym = "Значения полей")]
        public string ЗначенияПолей {get; set;}
        [Description1C8(Name = "Страна", Comment = "", Synonym = "Страна")]
        [StringLength(100)]
        public string Страна {get; set;}
        [Description1C8(Name = "Регион", Comment = "", Synonym = "Область")]
        [StringLength(50)]
        public string Регион {get; set;}
        [Description1C8(Name = "Город", Comment = "", Synonym = "Город")]
        [StringLength(50)]
        public string Город {get; set;}
        [Description1C8(Name = "АдресЭП", Comment = "", Synonym = "Адрес ЭП")]
        [StringLength(100)]
        public string АдресЭП {get; set;}
        [Description1C8(Name = "ДоменноеИмяСервера", Comment = "", Synonym = "Доменное имя сервера")]
        [StringLength(100)]
        public string ДоменноеИмяСервера {get; set;}
        [Description1C8(Name = "НомерТелефона", Comment = "", Synonym = "Номер телефона")]
        [StringLength(20)]
        public string НомерТелефона {get; set;}
        [Description1C8(Name = "НомерТелефонаБезКодов", Comment = "", Synonym = "Номер телефона без кодов")]
        [StringLength(20)]
        public string НомерТелефонаБезКодов {get; set;}
        [Description1C8(Name = "ВидДляСписка", Comment = "", Synonym = "Вид для списка")]
        public Catalogs.ВидыКонтактнойИнформации ВидДляСписка {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public string Значение {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Kontrahenty_DopolnytelnyeRekvyzyty")]
    public class Контрагенты_ДополнительныеРеквизиты
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
    [Description1C8(Name = "ИсторияКонтактнойИнформации", Comment = "", Synonym = "История контактной информации")]
    [Table("Kontrahenty_YstoryiaKontaktnoiYnformatsyy")]
    public class Контрагенты_ИсторияКонтактнойИнформации
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
        public Catalogs.ВидыКонтактнойИнформации Вид {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представление")]
        [StringLength(500)]
        public string Представление {get; set;}
        [Description1C8(Name = "ЗначенияПолей", Comment = "", Synonym = "Значения полей")]
        public string ЗначенияПолей {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public string Значение {get; set;}
    }
}

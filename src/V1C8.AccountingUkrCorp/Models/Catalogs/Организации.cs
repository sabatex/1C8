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
    [Table("Orhanyzatsyy")]
    [Description1C8(Name = "Организации", Comment = "", Synonym = "Организации")]
    public class Организации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "БанковскийСчетДляРасчетовСФСС", Comment = "", Synonym = "Банковский счет (для ФСС)")]
        public Catalogs.БанковскиеСчета БанковскийСчетДляРасчетовСФСС {get; set;}
        [Description1C8(Name = "ГоловнаяОрганизация", Comment = "(Общ)", Synonym = "Головная организация")]
        public Catalogs.Организации ГоловнаяОрганизация {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.Календари ГрафикРаботы {get; set;}
        [Description1C8(Name = "ДатаНачалаИспользованияЗвит1С", Comment = "", Synonym = "Дата начала использования 'FREDO Звіт'")]
        public DateTime ДатаНачалаИспользованияЗвит1С {get; set;}
        [Description1C8(Name = "ИндивидуальныйПредприниматель", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ИндивидуальныйПредприниматель {get; set;}
        [Description1C8(Name = "НаименованиеСокращенное", Comment = "", Synonym = "Сокращенное юр. наименование")]
        [StringLength(250)]
        public string НаименованиеСокращенное {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУ", Comment = "Код ЕДРПОУ", Synonym = "Код по ЕДРПОУ")]
        [StringLength(20)]
        public string КодПоЕДРПОУ {get; set;}
        [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
        [StringLength(250)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "ГрафикРаботыСотрудников", Comment = "", Synonym = "График работы сотрудников")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыСотрудников {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public bool ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ОсновнойБанковскийСчет", Comment = "(Общ)", Synonym = "Основной банковский счет")]
        public Catalogs.БанковскиеСчета ОсновнойБанковскийСчет {get; set;}
        [Description1C8(Name = "Префикс", Comment = "", Synonym = "Префикс")]
        [StringLength(2)]
        public string Префикс {get; set;}
        [Description1C8(Name = "ПрефиксБ12", Comment = "(Общ)", Synonym = "Префикс (бух 1.2)")]
        [StringLength(3)]
        public string ПрефиксБ12 {get; set;}
        [Description1C8(Name = "УдалитьФайлЛоготип", Comment = "", Synonym = "(не используется) Логотип")]
        public Catalogs.Файлы УдалитьФайлЛоготип {get; set;}
        [Description1C8(Name = "УдалитьФайлФаксимильнаяПечать", Comment = "", Synonym = "(не используется) Факсимильная печать")]
        public Catalogs.Файлы УдалитьФайлФаксимильнаяПечать {get; set;}
        [Description1C8(Name = "УдалитьФайлФаксимильнаяПодпись", Comment = "", Synonym = "(не используется) Факсимильная подпись")]
        public Catalogs.Файлы УдалитьФайлФаксимильнаяПодпись {get; set;}
        [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "", Synonym = "Юридическое / физическое лицо")]
        public Enums.ЮридическоеФизическоеЛицо ЮридическоеФизическоеЛицо {get; set;}
        [Description1C8(Name = "ФайлЛоготип", Comment = "", Synonym = "Логотип")]
        public Catalogs.ОрганизацииПрисоединенныеФайлы ФайлЛоготип {get; set;}
        [Description1C8(Name = "ФайлФаксимильнаяПечать", Comment = "", Synonym = "Факсимильная печать")]
        public Catalogs.ОрганизацииПрисоединенныеФайлы ФайлФаксимильнаяПечать {get; set;}
        [Description1C8(Name = "ФайлФаксимильнаяПодпись", Comment = "", Synonym = "Факсимильная подпись")]
        public Catalogs.ОрганизацииПрисоединенныеФайлы ФайлФаксимильнаяПодпись {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<Организации_КонтактнаяИнформация> ОрганизацииКонтактнаяИнформация {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Организации_ДополнительныеРеквизиты> ОрганизацииДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "ИсторияКонтактнойИнформации", Comment = "", Synonym = "История контактной информации")]
        public List<Организации_ИсторияКонтактнойИнформации> ОрганизацииИсторияКонтактнойИнформации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    [Table("Orhanyzatsyy_KontaktnaiaYnformatsyia")]
    public class Организации_КонтактнаяИнформация
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
    [Table("Orhanyzatsyy_DopolnytelnyeRekvyzyty")]
    public class Организации_ДополнительныеРеквизиты
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
    [Table("Orhanyzatsyy_YstoryiaKontaktnoiYnformatsyy")]
    public class Организации_ИсторияКонтактнойИнформации
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

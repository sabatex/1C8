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
    [Table("YspolnytelnyiLyst")]
    [Description1C8(Name = "ИсполнительныйЛист", Comment = "", Synonym = "Исполнительный лист")]
    public class ИсполнительныйЛист:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидИсполнительногоДокумента", Comment = "", Synonym = "Вид исполнительного документа")]
        public Enums.ВидыИсполнительныхДокументов ВидИсполнительногоДокумента {get; set;}
        [Description1C8(Name = "РеквизитыИсполнительногоДокумента", Comment = "", Synonym = "Реквизиты исполнительного документа")]
        public string РеквизитыИсполнительногоДокумента {get; set;}
        [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Получатель {get; set;}
        [Description1C8(Name = "АдресПолучателя", Comment = "", Synonym = "Адрес получателя")]
        public string АдресПолучателя {get; set;}
        [Description1C8(Name = "АдресПолучателяПредставление", Comment = "", Synonym = "Адрес получателя")]
        public string АдресПолучателяПредставление {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "СпособРасчета", Comment = "", Synonym = "Способ расчета")]
        public Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу СпособРасчета {get; set;}
        [Description1C8(Name = "ВидБазы", Comment = "", Synonym = "Вид базы")]
        public Enums.ВидыБазыУдержанияПоИсполнительномуДокументу ВидБазы {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "Процент", Comment = "", Synonym = "Процент")]
        // Format 5.2
        public decimal Процент {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 13.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Числитель", Comment = "", Synonym = "Числитель")]
        // Format 2.0
        public long Числитель {get; set;}
        [Description1C8(Name = "Знаменатель", Comment = "", Synonym = "Знаменатель")]
        // Format 2.0
        public long Знаменатель {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.2
        public decimal Предел {get; set;}
        [Description1C8(Name = "УчитыватьБольничныеЛисты", Comment = "", Synonym = "Учитывать больничные листы")]
        public bool УчитыватьБольничныеЛисты {get; set;}
        [Description1C8(Name = "ПлатежныйАгент", Comment = "", Synonym = "Платежный агент")]
        public Catalogs.Контрагенты ПлатежныйАгент {get; set;}
        [Description1C8(Name = "ТарифПлатежногоАгента", Comment = "", Synonym = "Тариф платежного агента")]
        public Catalogs.ТарифыПлатежныхАгентов ТарифПлатежногоАгента {get; set;}
        [Description1C8(Name = "УдержаниеВознагражденияПлатежногоАгента", Comment = "", Synonym = "Удержание вознаграждения платежного агента")]
        public ПланВидовРасчета.Удержания УдержаниеВознагражденияПлатежногоАгента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПрожиточныйМинимум", Comment = "", Synonym = "Прожиточный минимум")]
        public Enums.СоциальныеГруппыНаселения ПрожиточныйМинимум {get; set;}
        [Description1C8(Name = "УвеличиватьУдержанияДоМинимума", Comment = "", Synonym = "Увеличивать удержания до минимума")]
        public bool УвеличиватьУдержанияДоМинимума {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ИсполнительныйЛист_ДополнительныеРеквизиты> ИсполнительныйЛистДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "Дети", Comment = "", Synonym = "Дети")]
        public List<ИсполнительныйЛист_Дети> ИсполнительныйЛистДети {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("YspolnytelnyiLyst_DopolnytelnyeRekvyzyty")]
    public class ИсполнительныйЛист_ДополнительныеРеквизиты
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
    [Description1C8(Name = "Дети", Comment = "", Synonym = "Дети")]
    [Table("YspolnytelnyiLyst_Dety")]
    public class ИсполнительныйЛист_Дети
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Нетрудоспособен", Comment = "", Synonym = "Нетрудоспособен")]
        public bool Нетрудоспособен {get; set;}
    }
}

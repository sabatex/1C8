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
    [Table("NaznachenyePodrabotky")]
    [Description1C8(Name = "НазначениеПодработки", Comment = "", Synonym = "Назначение подработки")]
    public class НазначениеПодработки:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ГоловнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
        public Catalogs.Сотрудники ГоловнойСотрудник {get; set;}
        [Description1C8(Name = "СовмещающийСотрудник", Comment = "", Synonym = "Совмещающий сотрудник")]
        public Catalogs.Сотрудники СовмещающийСотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "ОтсутствующийСотрудник", Comment = "", Synonym = "Отсутствующий сотрудник")]
        public Catalogs.Сотрудники ОтсутствующийСотрудник {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Колич. ставок")]
        // Format 22.20
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Утверждено", Comment = "", Synonym = "Утверждено")]
        public bool Утверждено {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.НазначениеПодработки ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ПКУ", Comment = "", Synonym = "ПКУ")]
        public Catalogs.РазрядыКатегорииДолжностей ПКУ {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<НазначениеПодработки_Начисления> НазначениеПодработкиНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<НазначениеПодработки_Показатели> НазначениеПодработкиПоказатели {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НазначениеПодработки_ФизическиеЛица> НазначениеПодработкиФизическиеЛица {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<НазначениеПодработки_ДополнительныеРеквизиты> НазначениеПодработкиДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("NaznachenyePodrabotky_Nachyslenyia")]
    public class НазначениеПодработки_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("NaznachenyePodrabotky_Pokazately")]
    public class НазначениеПодработки_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NaznachenyePodrabotky_FyzycheskyeLytsa")]
    public class НазначениеПодработки_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("NaznachenyePodrabotky_DopolnytelnyeRekvyzyty")]
    public class НазначениеПодработки_ДополнительныеРеквизиты
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
}

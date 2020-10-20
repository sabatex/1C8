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
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi")]
    [Description1C8(Name = "УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций", Comment = "(Регл)", Synonym = "(не используется) Ввод сведений о плановых начислениях работников организаций")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ИндексацияЗаработка", Comment = "", Synonym = "Индексация заработка")]
        public bool ИндексацияЗаработка {get; set;}
        [Description1C8(Name = "КоэффициентИндексацииЗаработка", Comment = "", Synonym = "Коэффициент индексации заработка")]
        // Format 5.2
        public decimal КоэффициентИндексацииЗаработка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОсновныеНачисления", Comment = "", Synonym = "Основные начисления")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ОсновныеНачисления> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийОсновныеНачисления {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_Взносы> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВзносы {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы на ФОТ")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ВзносыФОТ> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВзносыФОТ {get;set;}
        [Description1C8(Name = "НачисленияДо", Comment = "", Synonym = "Начисления до")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_НачисленияДо> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНачисленияДо {get;set;}
        [Description1C8(Name = "НачисленияПосле", Comment = "", Synonym = "Начисления после")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_НачисленияПосле> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНачисленияПосле {get;set;}
        [Description1C8(Name = "ПараметрыРасчетаИндексации", Comment = "", Synonym = "Параметры расчета индексации")]
        public List<УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ПараметрыРасчетаИндексации> УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизацийПараметрыРасчетаИндексации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОсновныеНачисления", Comment = "", Synonym = "Основные начисления")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_OsnovnyeNachyslenyia")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ОсновныеНачисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчета {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ВидыДействияСНачислением Действие {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "ДатаДействияКонец", Comment = "", Synonym = "Дата действия конец")]
        public DateTime ДатаДействияКонец {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_Vznosy")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ВидыДействияСНачислением Действие {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы на ФОТ")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_VznosyFOT")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ВидыДействияСНачислением Действие {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "НачисленияДо", Comment = "", Synonym = "Начисления до")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_NachyslenyiaDo")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_НачисленияДо
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДнейЗаМесяц", Comment = "", Synonym = "Норма дней за месяц")]
        // Format 7.2
        public decimal НормаДнейЗаМесяц {get; set;}
        [Description1C8(Name = "НормаЧасовЗаМесяц", Comment = "", Synonym = "Норма часов за месяц")]
        // Format 7.2
        public decimal НормаЧасовЗаМесяц {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Назначение", Comment = "Сотрудник, внутреннее совместительство, сотрудник которого заменяют", Synonym = "Назначение")]
        public Catalogs.Сотрудники Назначение {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "БазовыйПериодКонец", Comment = "", Synonym = "Базовый период конец")]
        public DateTime БазовыйПериодКонец {get; set;}
        [Description1C8(Name = "ОплаченоДнейЧасов", Comment = "", Synonym = "Оплачено дней часов")]
        // Format 16.2
        public decimal ОплаченоДнейЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 10.0
        public long НормаЧасов {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
    [Description1C8(Name = "НачисленияПосле", Comment = "", Synonym = "Начисления после")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_NachyslenyiaPosle")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_НачисленияПосле
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДнейЗаМесяц", Comment = "", Synonym = "Норма дней за месяц")]
        // Format 7.2
        public decimal НормаДнейЗаМесяц {get; set;}
        [Description1C8(Name = "НормаЧасовЗаМесяц", Comment = "", Synonym = "Норма часов за месяц")]
        // Format 7.2
        public decimal НормаЧасовЗаМесяц {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Назначение", Comment = "Сотрудник, внутреннее совместительство, сотрудник которого заменяют", Synonym = "Назначение")]
        public Catalogs.Сотрудники Назначение {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "БазовыйПериодКонец", Comment = "", Synonym = "Базовый период конец")]
        public DateTime БазовыйПериодКонец {get; set;}
        [Description1C8(Name = "ОплаченоДнейЧасов", Comment = "", Synonym = "Оплачено дней часов")]
        // Format 16.2
        public decimal ОплаченоДнейЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 10.0
        public long НормаЧасов {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
    [Description1C8(Name = "ПараметрыРасчетаИндексации", Comment = "", Synonym = "Параметры расчета индексации")]
    [Table("UdalytVvodSvedenyiOPlanovykhNachyslenyiakhRabotnykovOrhanyzatsyi_ParametryRaschetaYndeksatsyy")]
    public class УдалитьВводСведенийОПлановыхНачисленияхРаботниковОрганизаций_ПараметрыРасчетаИндексации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ТабельныйНомерСтрока", Comment = "", Synonym = "Табельный номер")]
        [StringLength(10)]
        public string ТабельныйНомерСтрока {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физ лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ДоходДо", Comment = "", Synonym = "Доход до")]
        // Format 15.3
        public decimal ДоходДо {get; set;}
        [Description1C8(Name = "ДоходПосле", Comment = "", Synonym = "Доход после")]
        // Format 15.3
        public decimal ДоходПосле {get; set;}
        [Description1C8(Name = "Повышение", Comment = "", Synonym = "Повышение")]
        // Format 15.3
        public decimal Повышение {get; set;}
        [Description1C8(Name = "ФиксированнаяИндексация", Comment = "", Synonym = "Фиксированная индексация")]
        // Format 15.3
        public decimal ФиксированнаяИндексация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
}

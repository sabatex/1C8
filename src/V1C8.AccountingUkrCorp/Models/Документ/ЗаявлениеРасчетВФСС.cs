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
    [Table("ZaiavlenyeRaschetVFSS")]
    [Description1C8(Name = "ЗаявлениеРасчетВФСС", Comment = "", Synonym = "Заявление-расчет в ФСС")]
    public class ЗаявлениеРасчетВФСС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "НазваниеРабочегоОрганаФонда", Comment = "", Synonym = "Название рабочего органа ФСС")]
        [StringLength(135)]
        public string НазваниеРабочегоОрганаФонда {get; set;}
        [Description1C8(Name = "НомерФСС", Comment = "", Synonym = "Регистрационный номер в ФСС")]
        [StringLength(20)]
        public string НомерФСС {get; set;}
        [Description1C8(Name = "НомерФССНесчСлучай", Comment = "", Synonym = "Регистрационный номер в ФСС НС")]
        [StringLength(20)]
        public string НомерФССНесчСлучай {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУ", Comment = "", Synonym = "Код по ЕДРПОУ")]
        [StringLength(10)]
        public string КодПоЕДРПОУ {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "АдресОрганизации", Comment = "", Synonym = "Адрес организации")]
        public string АдресОрганизации {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Банки Банк {get; set;}
        [Description1C8(Name = "НаименованиеБанка", Comment = "", Synonym = "Наименование банка")]
        [StringLength(100)]
        public string НаименованиеБанка {get; set;}
        [Description1C8(Name = "НомерЛицевогоСчета", Comment = "", Synonym = "Номер лицевого счета")]
        [StringLength(20)]
        public string НомерЛицевогоСчета {get; set;}
        [Description1C8(Name = "НомерСчета", Comment = "", Synonym = "Номер счета")]
        [StringLength(34)]
        public string НомерСчета {get; set;}
        [Description1C8(Name = "МФОБанка", Comment = "", Synonym = "МФО банка")]
        [StringLength(9)]
        public string МФОБанка {get; set;}
        [Description1C8(Name = "СтатусДокумента", Comment = "", Synonym = "Статус документа")]
        public Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий СтатусДокумента {get; set;}
        [Description1C8(Name = "ТелефонСоставителя", Comment = "", Synonym = "Телефон составителя")]
        public string ТелефонСоставителя {get; set;}
        [Description1C8(Name = "ЗаявлениеСоставил", Comment = "", Synonym = "Заявление составил")]
        public Catalogs.ФизическиеЛица ЗаявлениеСоставил {get; set;}
        [Description1C8(Name = "УдалитьБанк", Comment = "", Synonym = "(не используется) Банк")]
        public Catalogs.Банки УдалитьБанк {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ФондСоциальногоСтрахования", Comment = "", Synonym = "Фонд социального страхования")]
        public Enums.ВидыОбязательногоСтрахованияСотрудников ФондСоциальногоСтрахования {get; set;}
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "ФИОДиректораФонда", Comment = "", Synonym = "ФИО директора фонда")]
        public Catalogs.ФизическиеЛица ФИОДиректораФонда {get; set;}
        [Description1C8(Name = "КодКВЕД", Comment = "", Synonym = "Код по КВЕД")]
        [StringLength(20)]
        public string КодКВЕД {get; set;}
        [Description1C8(Name = "ДолжностьСоставителя", Comment = "", Synonym = "Должность составителя")]
        public Catalogs.Должности ДолжностьСоставителя {get; set;}
        [Description1C8(Name = "НомерФССУ", Comment = "Номер регистрации ФСС Украины", Synonym = "Номер регистрации ФСС Украины")]
        [StringLength(20)]
        public string НомерФССУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Оплаты", Comment = "", Synonym = "Оплаты")]
        public List<ЗаявлениеРасчетВФСС_Оплаты> ЗаявлениеРасчетВФССОплаты {get;set;}
        [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
        public List<ЗаявлениеРасчетВФСС_ФиксацияИзменений> ЗаявлениеРасчетВФССФиксацияИзменений {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ЗаявлениеРасчетВФСС_ФизическиеЛица> ЗаявлениеРасчетВФССФизическиеЛица {get;set;}
        [Description1C8(Name = "ПособияНаПогребение", Comment = "", Synonym = "Пособия на погребение")]
        public List<ЗаявлениеРасчетВФСС_ПособияНаПогребение> ЗаявлениеРасчетВФССПособияНаПогребение {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Оплаты", Comment = "", Synonym = "Оплаты")]
    [Table("ZaiavlenyeRaschetVFSS_Oplaty")]
    public class ЗаявлениеРасчетВФСС_Оплаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "Документ, который зарегистрировал начисление", Synonym = "Документ-основание")]
        public Документ.БольничныйЛист ДокументОснование {get; set;}
        [Description1C8(Name = "СуммаПособияВсего", Comment = "", Synonym = "Сумма пособия всего")]
        // Format 15.2
        public decimal СуммаПособияВсего {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиФикс", Comment = "", Synonym = "Идентификатор строки фикс")]
        // Format 5.0
        public long ИдентификаторСтрокиФикс {get; set;}
        [Description1C8(Name = "НомерБольничного", Comment = "", Synonym = "Номер больничного")]
        [StringLength(20)]
        public string НомерБольничного {get; set;}
        [Description1C8(Name = "ПричинаНетрудоспособности", Comment = "", Synonym = "Причина нетрудоспособности")]
        public Enums.ПричиныНетрудоспособности ПричинаНетрудоспособности {get; set;}
        [Description1C8(Name = "КоличествоДнейВсего", Comment = "", Synonym = "Количество дней всего")]
        // Format 4.0
        public long КоличествоДнейВсего {get; set;}
        [Description1C8(Name = "СуммаПособияВсегоФСС", Comment = "", Synonym = "Сумма пособия всего ФСС")]
        // Format 15.2
        public decimal СуммаПособияВсегоФСС {get; set;}
        [Description1C8(Name = "КоличествоДнейВсегоФСС", Comment = "", Synonym = "Количество дней всего ФСС")]
        // Format 4.0
        public long КоличествоДнейВсегоФСС {get; set;}
        [Description1C8(Name = "СуммаЛьготыЧернобыльцы", Comment = "", Synonym = "Сумма льготы чернобыльцы")]
        // Format 15.2
        public decimal СуммаЛьготыЧернобыльцы {get; set;}
        [Description1C8(Name = "ПериодС", Comment = "", Synonym = "Период С")]
        public DateTime ПериодС {get; set;}
        [Description1C8(Name = "ПериодПо", Comment = "", Synonym = "Период по")]
        public DateTime ПериодПо {get; set;}
    }
    [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
    [Table("ZaiavlenyeRaschetVFSS_FyksatsyiaYzmenenyi")]
    public class ЗаявлениеРасчетВФСС_ФиксацияИзменений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИмяРеквизита", Comment = "", Synonym = "Имя реквизита")]
        public string ИмяРеквизита {get; set;}
        [Description1C8(Name = "Путь", Comment = "", Synonym = "Путь")]
        public string Путь {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 5.0
        public long ИдентификаторСтроки {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("ZaiavlenyeRaschetVFSS_FyzycheskyeLytsa")]
    public class ЗаявлениеРасчетВФСС_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "ПособияНаПогребение", Comment = "", Synonym = "Пособия на погребение")]
    [Table("ZaiavlenyeRaschetVFSS_PosobyiaNaPohrebenye")]
    public class ЗаявлениеРасчетВФСС_ПособияНаПогребение
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "Документ, который зарегистрировал начисление", Synonym = "Документ-основание")]
        public Документ.ЕдиновременноеПособиеЗаСчетФСС ДокументОснование {get; set;}
        [Description1C8(Name = "РазмерПособия", Comment = "", Synonym = "Размер пособия")]
        // Format 15.2
        public decimal РазмерПособия {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиФикс", Comment = "", Synonym = "Идентификатор строки фикс")]
        // Format 5.0
        public long ИдентификаторСтрокиФикс {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксировано расчет")]
        public bool ФиксРасчет {get; set;}
    }
}

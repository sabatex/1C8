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
    [Table("UstareloVedomostNaVyplatuZarplatyVBank")]
    [Description1C8(Name = "УстарелоВедомостьНаВыплатуЗарплатыВБанк", Comment = "", Synonym = "ѳ(устарело) Ведомость в банк")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ЗарплатныйПроект", Comment = "", Synonym = "Зарплатный проект")]
        public Catalogs.УстарелоЗарплатныеПроекты ЗарплатныйПроект {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Выплата")]
        public Catalogs.УстарелоВидыВыплат СпособВыплаты {get; set;}
        [Description1C8(Name = "Округление", Comment = "", Synonym = "Округление")]
        public Catalogs.УстарелоСпособыОкругленияПриВыплатеЗарплаты Округление {get; set;}
        [Description1C8(Name = "СуммаПоДокументу", Comment = "", Synonym = "Сумма по документу")]
        // Format 15.2
        public decimal СуммаПоДокументу {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность руководителя")]
        public Catalogs.УстарелоДолжности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.ФизическиеЛица Бухгалтер {get; set;}
        [Description1C8(Name = "ВводНачальныхДанных", Comment = "", Synonym = "Ввод начальных данных")]
        public bool ВводНачальныхДанных {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_Зарплата> УстарелоВедомостьНаВыплатуЗарплатыВБанкЗарплата {get;set;}
        [Description1C8(Name = "ЗарплатаПодробно", Comment = "", Synonym = "Зарплата подробно")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_ЗарплатаПодробно> УстарелоВедомостьНаВыплатуЗарплатыВБанкЗарплатаПодробно {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_НДФЛ> УстарелоВедомостьНаВыплатуЗарплатыВБанкНДФЛ {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_Взносы> УстарелоВедомостьНаВыплатуЗарплатыВБанкВзносы {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_ВзносыФОТ> УстарелоВедомостьНаВыплатуЗарплатыВБанкВзносыФОТ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВБанк_ФизическиеЛица> УстарелоВедомостьНаВыплатуЗарплатыВБанкФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_Zarplata")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_Зарплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "КВыплате", Comment = "", Synonym = "К выплате")]
        // Format 15.2
        public decimal КВыплате {get; set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "НомерЛицевогоСчета", Comment = "", Synonym = "Номер лицевого счета")]
        [StringLength(20)]
        public string НомерЛицевогоСчета {get; set;}
    }
    [Description1C8(Name = "ЗарплатаПодробно", Comment = "", Synonym = "Зарплата подробно")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_ZarplataPodrobno")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_ЗарплатаПодробно
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "КВыплате", Comment = "", Synonym = "К выплате")]
        // Format 15.2
        public decimal КВыплате {get; set;}
        [Description1C8(Name = "СуммаГрязными", Comment = "", Synonym = "Сумма 'грязными'")]
        // Format 15.2
        public decimal СуммаГрязными {get; set;}
        [Description1C8(Name = "СуммаОкругления", Comment = "", Synonym = "Сумма округления")]
        // Format 10.2
        public decimal СуммаОкругления {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость")]
        public Документ.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_NDFL")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_Vznosy")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 18.6
        public decimal Сумма {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_VznosyFOT")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 18.6
        public decimal Сумма {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("UstareloVedomostNaVyplatuZarplatyVBank_FyzycheskyeLytsa")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВБанк_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}

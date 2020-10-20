using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu")]
    [Description1C8(Name = "УстарелоВедомостьНаВыплатуЗарплатыВКассу", Comment = "", Synonym = "ѳ(устарело) Ведомость в кассу")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Способ выплаты")]
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
        [Description1C8(Name = "Кассир", Comment = "", Synonym = "Кассир")]
        public Catalogs.ФизическиеЛица Кассир {get; set;}
        [Description1C8(Name = "ДолжностьКассира", Comment = "", Synonym = "Должность кассира")]
        public Catalogs.УстарелоДолжности ДолжностьКассира {get; set;}
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
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_Зарплата> УстарелоВедомостьНаВыплатуЗарплатыВКассуЗарплата {get;set;}
        [Description1C8(Name = "ЗарплатаПодробно", Comment = "", Synonym = "Зарплата подробно")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_ЗарплатаПодробно> УстарелоВедомостьНаВыплатуЗарплатыВКассуЗарплатаПодробно {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_НДФЛ> УстарелоВедомостьНаВыплатуЗарплатыВКассуНДФЛ {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_Взносы> УстарелоВедомостьНаВыплатуЗарплатыВКассуВзносы {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_ВзносыФОТ> УстарелоВедомостьНаВыплатуЗарплатыВКассуВзносыФОТ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<УстарелоВедомостьНаВыплатуЗарплатыВКассу_ФизическиеЛица> УстарелоВедомостьНаВыплатуЗарплатыВКассуФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_Zarplata")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_Зарплата
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
    }
    [Description1C8(Name = "ЗарплатаПодробно", Comment = "", Synonym = "Зарплата подробно")]
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_ZarplataPodrobno")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_ЗарплатаПодробно
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
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_NDFL")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_НДФЛ
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
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_Vznosy")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_Взносы
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
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_VznosyFOT")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_ВзносыФОТ
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
    [Table("UstareloVedomostNaVyplatuZarplatyVKassu_FyzycheskyeLytsa")]
    public class УстарелоВедомостьНаВыплатуЗарплатыВКассу_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}

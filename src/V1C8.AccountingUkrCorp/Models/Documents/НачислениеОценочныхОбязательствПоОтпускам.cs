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
    [Table("NachyslenyeOtsenochnykhObiazatelstvPoOtpuskam")]
    [Description1C8(Name = "НачислениеОценочныхОбязательствПоОтпускам", Comment = "", Synonym = "Начисление оценочных обязательств по отпускам")]
    public class НачислениеОценочныхОбязательствПоОтпускам:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ОбязательстваОтраженыВБухучете", Comment = "", Synonym = "Обязательства отражены в бухучете")]
        public bool ОбязательстваОтраженыВБухучете {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.Пользователи Бухгалтер {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КорректировкаОбязательств", Comment = "", Synonym = "Корректировка обязательств")]
        public bool КорректировкаОбязательств {get; set;}
        [Description1C8(Name = "ДоляРасходов", Comment = "", Synonym = "Доля расходов")]
        // Format 15.2
        public decimal ДоляРасходов {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасчетРезерваОтпусков", Comment = "Расчет обязательств и резервов по отпускам", Synonym = "Расчет обязательств и резервов по отпускам")]
        public List<НачислениеОценочныхОбязательствПоОтпускам_РасчетРезерваОтпусков> НачислениеОценочныхОбязательствПоОтпускамРасчетРезерваОтпусков {get;set;}
        [Description1C8(Name = "ОценочныеОбязательстваПоВознаграждениямРаботникам", Comment = "", Synonym = "Оценочные обязательства по вознаграждениям работникам")]
        public List<НачислениеОценочныхОбязательствПоОтпускам_ОценочныеОбязательстваПоВознаграждениямРаботникам> НачислениеОценочныхОбязательствПоОтпускамОценочныеОбязательстваПоВознаграждениямРаботникам {get;set;}
        [Description1C8(Name = "ОценочныеОбязательства", Comment = "", Synonym = "Оценочные обязательства текущего месяца")]
        public List<НачислениеОценочныхОбязательствПоОтпускам_ОценочныеОбязательства> НачислениеОценочныхОбязательствПоОтпускамОценочныеОбязательства {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НачислениеОценочныхОбязательствПоОтпускам_ФизическиеЛица> НачислениеОценочныхОбязательствПоОтпускамФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасчетРезерваОтпусков", Comment = "Расчет обязательств и резервов по отпускам", Synonym = "Расчет обязательств и резервов по отпускам")]
    [Table("NachyslenyeOtsenochnykhObiazatelstvPoOtpuskam_RaschetRezervaOtpuskov")]
    public class НачислениеОценочныхОбязательствПоОтпускам_РасчетРезерваОтпусков
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФОТ", Comment = "", Synonym = "ФОТ")]
        // Format 12.2
        public decimal ФОТ {get; set;}
        [Description1C8(Name = "ОстатокОтпуска", Comment = "", Synonym = "Остаток отпуска")]
        // Format 5.2
        public decimal ОстатокОтпуска {get; set;}
        [Description1C8(Name = "СреднийЗаработок", Comment = "", Synonym = "Средний заработок")]
        // Format 15.2
        public decimal СреднийЗаработок {get; set;}
        [Description1C8(Name = "СуммаРезерва", Comment = "", Synonym = "Сумма резерва")]
        // Format 15.2
        public decimal СуммаРезерва {get; set;}
        [Description1C8(Name = "СуммаРезерваНакоплено", Comment = "", Synonym = "Сумма резерва (накоплено)")]
        // Format 15.2
        public decimal СуммаРезерваНакоплено {get; set;}
        [Description1C8(Name = "СуммаРезерваИсчислено", Comment = "", Synonym = "Сумма резерва (исчислено)")]
        // Format 15.2
        public decimal СуммаРезерваИсчислено {get; set;}
        [Description1C8(Name = "СтраховыеВзносы", Comment = "", Synonym = "Страховые взносы")]
        // Format 15.2
        public decimal СтраховыеВзносы {get; set;}
        [Description1C8(Name = "ТекущаяСтавкаСтраховыхВзносов", Comment = "", Synonym = "% страховых взносов")]
        // Format 7.4
        public decimal ТекущаяСтавкаСтраховыхВзносов {get; set;}
        [Description1C8(Name = "СуммаРезерваСтраховыхВзносов", Comment = "", Synonym = "Сумма резерва страховых взносов")]
        // Format 15.2
        public decimal СуммаРезерваСтраховыхВзносов {get; set;}
        [Description1C8(Name = "СуммаРезерваСтраховыхВзносовНакоплено", Comment = "", Synonym = "Сумма резерва страховых взносов (накоплено)")]
        // Format 15.2
        public decimal СуммаРезерваСтраховыхВзносовНакоплено {get; set;}
        [Description1C8(Name = "СуммаРезерваСтраховыхВзносовИсчислено", Comment = "", Synonym = "Сумма резерва страховых взносов (исчислено)")]
        // Format 15.2
        public decimal СуммаРезерваСтраховыхВзносовИсчислено {get; set;}
        [Description1C8(Name = "ОтпускАвансом", Comment = "", Synonym = "Отпуск авансом")]
        // Format 5.2
        public decimal ОтпускАвансом {get; set;}
    }
    [Description1C8(Name = "ОценочныеОбязательстваПоВознаграждениямРаботникам", Comment = "", Synonym = "Оценочные обязательства по вознаграждениям работникам")]
    [Table("NachyslenyeOtsenochnykhObiazatelstvPoOtpuskam_OtsenochnyeObiazatelstvaPoVoznahrazhdenyiamRabotnykam")]
    public class НачислениеОценочныхОбязательствПоОтпускам_ОценочныеОбязательстваПоВознаграждениямРаботникам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СуммаРезерва", Comment = "", Synonym = "Сумма резерва")]
        // Format 15.2
        public decimal СуммаРезерва {get; set;}
        [Description1C8(Name = "СуммаРезерваСтраховыхВзносов", Comment = "", Synonym = "Сумма резерва страховых взносов")]
        // Format 15.2
        public decimal СуммаРезерваСтраховыхВзносов {get; set;}
    }
    [Description1C8(Name = "ОценочныеОбязательства", Comment = "", Synonym = "Оценочные обязательства текущего месяца")]
    [Table("NachyslenyeOtsenochnykhObiazatelstvPoOtpuskam_OtsenochnyeObiazatelstva")]
    public class НачислениеОценочныхОбязательствПоОтпускам_ОценочныеОбязательства
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СуммаРезерва", Comment = "", Synonym = "Сумма резерва")]
        // Format 15.2
        public decimal СуммаРезерва {get; set;}
        [Description1C8(Name = "СуммаРезерваСтраховыхВзносов", Comment = "", Synonym = "Сумма резерва страховых взносов")]
        // Format 15.2
        public decimal СуммаРезерваСтраховыхВзносов {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение предприятия")]
        public Catalogs.СтруктураПредприятия ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NachyslenyeOtsenochnykhObiazatelstvPoOtpuskam_FyzycheskyeLytsa")]
    public class НачислениеОценочныхОбязательствПоОтпускам_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}

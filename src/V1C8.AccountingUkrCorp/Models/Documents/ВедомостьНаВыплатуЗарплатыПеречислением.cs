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
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem")]
    [Description1C8(Name = "ВедомостьНаВыплатуЗарплатыПеречислением", Comment = "", Synonym = "Ведомость перечислений на счета")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Банки Банк {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Способ выплаты")]
        public Catalogs.СпособыВыплатыЗарплаты СпособВыплаты {get; set;}
        [Description1C8(Name = "Округление", Comment = "", Synonym = "Округление")]
        public Catalogs.СпособыОкругленияПриРасчетеЗарплаты Округление {get; set;}
        [Description1C8(Name = "ПроцентВыплаты", Comment = "", Synonym = "Процент выплаты")]
        // Format 3.0
        public long ПроцентВыплаты {get; set;}
        [Description1C8(Name = "СуммаПоДокументу", Comment = "", Synonym = "Сумма по документу")]
        // Format 15.2
        public decimal СуммаПоДокументу {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность руководителя")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.ФизическиеЛица Бухгалтер {get; set;}
        [Description1C8(Name = "ВводНачальныхДанных", Comment = "", Synonym = "Ввод начальных данных")]
        public bool ВводНачальныхДанных {get; set;}
        [Description1C8(Name = "ПеречислениеНДФЛВыполнено", Comment = "", Synonym = "Перечисление НДФЛ выполнено")]
        public bool ПеречислениеНДФЛВыполнено {get; set;}
        [Description1C8(Name = "ПеречислениеНДФЛРеквизиты", Comment = "", Synonym = "Перечисление НДФЛ реквизиты платежного документа")]
        [StringLength(50)]
        public string ПеречислениеНДФЛРеквизиты {get; set;}
        [Description1C8(Name = "УдалитьБанк", Comment = "", Synonym = "(не используется) Банк")]
        public Catalogs.Банки УдалитьБанк {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПорядокЗаполненияНалогов", Comment = "", Synonym = "Порядок заполнения налогов")]
        public Enums.ПорядокЗаполненияНалогов ПорядокЗаполненияНалогов {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Состав", Comment = "", Synonym = "Состав")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_Состав> ВедомостьНаВыплатуЗарплатыПеречислениемСостав {get;set;}
        [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_Зарплата> ВедомостьНаВыплатуЗарплатыПеречислениемЗарплата {get;set;}
        [Description1C8(Name = "Основания", Comment = "", Synonym = "Основания")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_Основания> ВедомостьНаВыплатуЗарплатыПеречислениемОснования {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_НДФЛ> ВедомостьНаВыплатуЗарплатыПеречислениемНДФЛ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_ФизическиеЛица> ВедомостьНаВыплатуЗарплатыПеречислениемФизическиеЛица {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<ВедомостьНаВыплатуЗарплатыПеречислением_ВзносыФОТ> ВедомостьНаВыплатуЗарплатыПеречислениемВзносыФОТ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Состав")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_Sostav")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_Состав
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        public Guid ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "БанковскийСчет", Comment = "", Synonym = "Банковский счет")]
        public Catalogs.БанковскиеСчета БанковскийСчет {get; set;}
    }
    [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_Zarplata")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_Зарплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        public Guid ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ-основание")]
        public Documents.ЕдиновременноеПособиеЗаСчетФСС ДокументОснование {get; set;}
        [Description1C8(Name = "КВыплате", Comment = "", Synonym = "К выплате")]
        // Format 15.2
        public decimal КВыплате {get; set;}
        [Description1C8(Name = "КомпенсацияЗаЗадержкуЗарплаты", Comment = "Компенсация за нарушение установленного срока выплаты зарплаты в соответствии со ст.236 Трудового Кодекса", Synonym = "Компенсация за задержку зарплаты")]
        // Format 15.2
        public decimal КомпенсацияЗаЗадержкуЗарплаты {get; set;}
        [Description1C8(Name = "БанковскийСчет", Comment = "", Synonym = "Банковский счет")]
        public Catalogs.БанковскиеСчета БанковскийСчет {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "Основания", Comment = "", Synonym = "Основания")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_Osnovanyia")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_Основания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Documents.СторнированиеНачислений Документ {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_NDFL")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        public Guid ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "МесяцНалоговогоПериода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime МесяцНалоговогоПериода {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.ПризПодарок ДокументОснование {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ГруппаУчетаУдержаний", Comment = "", Synonym = "Группа учета удержаний")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаУдержаний {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделение {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_FyzycheskyeLytsa")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("VedomostNaVyplatuZarplatyPerechyslenyem_VznosyFOT")]
    public class ВедомостьНаВыплатуЗарплатыПеречислением_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "Месяц, которым сумма попадет в отчетность", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.ПризПодарок ДокументОснование {get; set;}
    }
}

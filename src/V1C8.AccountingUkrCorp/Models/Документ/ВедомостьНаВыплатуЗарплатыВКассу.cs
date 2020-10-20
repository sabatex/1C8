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
    [Table("VedomostNaVyplatuZarplatyVKassu")]
    [Description1C8(Name = "ВедомостьНаВыплатуЗарплатыВКассу", Comment = "", Synonym = "Ведомость в кассу")]
    public class ВедомостьНаВыплатуЗарплатыВКассу:DocumentItem
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
        [Description1C8(Name = "Касса", Comment = "", Synonym = "Касса")]
        [StringLength(10)]
        public string Касса {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Выплата")]
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
        [Description1C8(Name = "Кассир", Comment = "", Synonym = "Кассир")]
        public Catalogs.ФизическиеЛица Кассир {get; set;}
        [Description1C8(Name = "ДолжностьКассира", Comment = "", Synonym = "Должность кассира")]
        public Catalogs.Должности ДолжностьКассира {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.ФизическиеЛица Бухгалтер {get; set;}
        [Description1C8(Name = "ВводНачальныхДанных", Comment = "", Synonym = "Ввод начальных данных")]
        public bool ВводНачальныхДанных {get; set;}
        [Description1C8(Name = "ПеречислениеНДФЛВыполнено", Comment = "", Synonym = "Перечисление НДФЛ выполнено")]
        public bool ПеречислениеНДФЛВыполнено {get; set;}
        [Description1C8(Name = "ПеречислениеНДФЛРеквизиты", Comment = "", Synonym = "Перечисление НДФЛ реквизиты платежного документа")]
        [StringLength(50)]
        public string ПеречислениеНДФЛРеквизиты {get; set;}
        [Description1C8(Name = "Составил", Comment = "", Synonym = "Составил")]
        public Catalogs.ФизическиеЛица Составил {get; set;}
        [Description1C8(Name = "ДолжностьСоставившего", Comment = "", Synonym = "Должность составившего")]
        public Catalogs.Должности ДолжностьСоставившего {get; set;}
        [Description1C8(Name = "Проверил", Comment = "", Synonym = "Проверил")]
        public Catalogs.ФизическиеЛица Проверил {get; set;}
        [Description1C8(Name = "ДолжностьПроверившего", Comment = "", Synonym = "Должность проверившего")]
        public Catalogs.Должности ДолжностьПроверившего {get; set;}
        [Description1C8(Name = "Раздатчик", Comment = "", Synonym = "Раздатчик")]
        public Catalogs.ФизическиеЛица Раздатчик {get; set;}
        [Description1C8(Name = "ДолжностьРаздатчика", Comment = "", Synonym = "Должность раздатчика")]
        public Catalogs.Должности ДолжностьРаздатчика {get; set;}
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
        public List<ВедомостьНаВыплатуЗарплатыВКассу_Состав> ВедомостьНаВыплатуЗарплатыВКассуСостав {get;set;}
        [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
        public List<ВедомостьНаВыплатуЗарплатыВКассу_Зарплата> ВедомостьНаВыплатуЗарплатыВКассуЗарплата {get;set;}
        [Description1C8(Name = "Основания", Comment = "", Synonym = "Основания")]
        public List<ВедомостьНаВыплатуЗарплатыВКассу_Основания> ВедомостьНаВыплатуЗарплатыВКассуОснования {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<ВедомостьНаВыплатуЗарплатыВКассу_НДФЛ> ВедомостьНаВыплатуЗарплатыВКассуНДФЛ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ВедомостьНаВыплатуЗарплатыВКассу_ФизическиеЛица> ВедомостьНаВыплатуЗарплатыВКассуФизическиеЛица {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<ВедомостьНаВыплатуЗарплатыВКассу_ВзносыФОТ> ВедомостьНаВыплатуЗарплатыВКассуВзносыФОТ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Состав")]
    [Table("VedomostNaVyplatuZarplatyVKassu_Sostav")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_Состав
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        public Guid ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "Зарплата", Comment = "", Synonym = "Зарплата")]
    [Table("VedomostNaVyplatuZarplatyVKassu_Zarplata")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_Зарплата
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
        public Документ.ЕдиновременноеПособиеЗаСчетФСС ДокументОснование {get; set;}
        [Description1C8(Name = "КВыплате", Comment = "", Synonym = "К выплате")]
        // Format 15.2
        public decimal КВыплате {get; set;}
        [Description1C8(Name = "КомпенсацияЗаЗадержкуЗарплаты", Comment = "Компенсация за нарушение установленного срока выплаты зарплаты в соответствии со ст.236 Трудового Кодекса", Synonym = "Компенсация за задержку зарплаты")]
        // Format 15.2
        public decimal КомпенсацияЗаЗадержкуЗарплаты {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "Основания", Comment = "", Synonym = "Основания")]
    [Table("VedomostNaVyplatuZarplatyVKassu_Osnovanyia")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_Основания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Документ.СторнированиеНачислений Документ {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("VedomostNaVyplatuZarplatyVKassu_NDFL")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        public Guid ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "МесяцНалоговогоПериода", Comment = "", Synonym = "Месяц налогового периода")]
        public DateTime МесяцНалоговогоПериода {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ПризПодарок ДокументОснование {get; set;}
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
    [Table("VedomostNaVyplatuZarplatyVKassu_FyzycheskyeLytsa")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("VedomostNaVyplatuZarplatyVKassu_VznosyFOT")]
    public class ВедомостьНаВыплатуЗарплатыВКассу_ВзносыФОТ
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
        public Документ.ПризПодарок ДокументОснование {get; set;}
    }
}

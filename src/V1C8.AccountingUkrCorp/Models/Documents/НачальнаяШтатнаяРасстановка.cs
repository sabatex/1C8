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
    [Table("NachalnaiaShtatnaiaRasstanovka")]
    [Description1C8(Name = "НачальнаяШтатнаяРасстановка", Comment = "", Synonym = "Начальная штатная расстановка")]
    public class НачальнаяШтатнаяРасстановка:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public Enums.ВидыДоговоровССотрудниками ВидДоговора {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<НачальнаяШтатнаяРасстановка_Сотрудники> НачальнаяШтатнаяРасстановкаСотрудники {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<НачальнаяШтатнаяРасстановка_Начисления> НачальнаяШтатнаяРасстановкаНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<НачальнаяШтатнаяРасстановка_Показатели> НачальнаяШтатнаяРасстановкаПоказатели {get;set;}
        [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
        public List<НачальнаяШтатнаяРасстановка_ЕжегодныеОтпуска> НачальнаяШтатнаяРасстановкаЕжегодныеОтпуска {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НачальнаяШтатнаяРасстановка_ФизическиеЛица> НачальнаяШтатнаяРасстановкаФизическиеЛица {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<НачальнаяШтатнаяРасстановка_Льготы> НачальнаяШтатнаяРасстановкаЛьготы {get;set;}
        [Description1C8(Name = "ОстаткиОтпусковПоРабочимГодам", Comment = "", Synonym = "Остатки отпусков по рабочим годам")]
        public List<НачальнаяШтатнаяРасстановка_ОстаткиОтпусковПоРабочимГодам> НачальнаяШтатнаяРасстановкаОстаткиОтпусковПоРабочимГодам {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("NachalnaiaShtatnaiaRasstanovka_Sotrudnyky")]
    public class НачальнаяШтатнаяРасстановка_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Колич. ставок")]
        // Format 22.20
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДатаПриема", Comment = "", Synonym = "Дата приема")]
        public DateTime ДатаПриема {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "Грейд", Comment = "", Synonym = "Грейд")]
        [StringLength(10)]
        public string Грейд {get; set;}
        [Description1C8(Name = "ПКУ", Comment = "", Synonym = "ПКУ")]
        public Catalogs.РазрядыКатегорииДолжностей ПКУ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ПринятНаНовоеРабочееМесто", Comment = "", Synonym = "Принят на новое рабочее место")]
        public bool ПринятНаНовоеРабочееМесто {get; set;}
        [Description1C8(Name = "ДатаСозданияРабочегоМеста", Comment = "", Synonym = "Дата создания рабочего места")]
        public DateTime ДатаСозданияРабочегоМеста {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("NachalnaiaShtatnaiaRasstanovka_Nachyslenyia")]
    public class НачальнаяШтатнаяРасстановка_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Действует по")]
        public DateTime ДатаОкончания {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("NachalnaiaShtatnaiaRasstanovka_Pokazately")]
    public class НачальнаяШтатнаяРасстановка_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
    [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
    [Table("NachalnaiaShtatnaiaRasstanovka_EzhehodnyeOtpuska")]
    public class НачальнаяШтатнаяРасстановка_ЕжегодныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
        [Description1C8(Name = "ДатаОстатка", Comment = "", Synonym = "Дата остатка")]
        public DateTime ДатаОстатка {get; set;}
        [Description1C8(Name = "УдалитьРабочийГодНачало", Comment = "", Synonym = "(не используется) С")]
        public DateTime УдалитьРабочийГодНачало {get; set;}
        [Description1C8(Name = "УдалитьРабочийГодОкончание", Comment = "", Synonym = "(не используется) По")]
        public DateTime УдалитьРабочийГодОкончание {get; set;}
        [Description1C8(Name = "КоличествоДней", Comment = "", Synonym = "Остаток")]
        // Format 5.2
        public decimal КоличествоДней {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NachalnaiaShtatnaiaRasstanovka_FyzycheskyeLytsa")]
    public class НачальнаяШтатнаяРасстановка_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("NachalnaiaShtatnaiaRasstanovka_Lhoty")]
    public class НачальнаяШтатнаяРасстановка_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public ПланВидовРасчета.Начисления Льгота {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ОстаткиОтпусковПоРабочимГодам", Comment = "", Synonym = "Остатки отпусков по рабочим годам")]
    [Table("NachalnaiaShtatnaiaRasstanovka_OstatkyOtpuskovPoRabochymHodam")]
    public class НачальнаяШтатнаяРасстановка_ОстаткиОтпусковПоРабочимГодам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "ДатаОстатка", Comment = "", Synonym = "Дата остатка")]
        public DateTime ДатаОстатка {get; set;}
        [Description1C8(Name = "РабочийГодНачало", Comment = "", Synonym = "С")]
        public DateTime РабочийГодНачало {get; set;}
        [Description1C8(Name = "РабочийГодОкончание", Comment = "", Synonym = "По")]
        public DateTime РабочийГодОкончание {get; set;}
        [Description1C8(Name = "Остаток", Comment = "", Synonym = "Остаток")]
        // Format 5.2
        public decimal Остаток {get; set;}
    }
}

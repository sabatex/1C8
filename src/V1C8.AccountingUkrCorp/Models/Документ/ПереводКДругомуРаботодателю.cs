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
    [Table("PerevodKDruhomuRabotodateliu")]
    [Description1C8(Name = "ПереводКДругомуРаботодателю", Comment = "", Synonym = "Перевод к другому работодателю")]
    public class ПереводКДругомуРаботодателю:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаУвольнения", Comment = "", Synonym = "Дата увольнения")]
        public DateTime ДатаУвольнения {get; set;}
        [Description1C8(Name = "НоваяОрганизация", Comment = "", Synonym = "Новая организация")]
        public Catalogs.Организации НоваяОрганизация {get; set;}
        [Description1C8(Name = "ДатаПриема", Comment = "", Synonym = "Дата приема на работу")]
        public DateTime ДатаПриема {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Количество ставок")]
        // Format 22.20
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
        [Description1C8(Name = "СтатьяКЗОТ", Comment = "", Synonym = "Статья КЗоТ")]
        public Catalogs.ОснованияУвольнения СтатьяКЗОТ {get; set;}
        [Description1C8(Name = "ПереноситьОстаткиОтпуска", Comment = "", Synonym = "Переносить остатки отпуска")]
        public bool ПереноситьОстаткиОтпуска {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "РуководительНовойОрганизации", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица РуководительНовойОрганизации {get; set;}
        [Description1C8(Name = "ДолжностьРуководителяНовойОрганизации", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителяНовойОрганизации {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд категория")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПКУ", Comment = "", Synonym = "ПКУ")]
        public Catalogs.РазрядыКатегорииДолжностей ПКУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДанныеОДоходах", Comment = "", Synonym = "Данные о доходах")]
        public List<ПереводКДругомуРаботодателю_ДанныеОДоходах> ПереводКДругомуРаботодателюДанныеОДоходах {get;set;}
        [Description1C8(Name = "ДанныеОЗаработкеДляРасчетаПособий", Comment = "", Synonym = "Данные о заработке для расчета пособий")]
        public List<ПереводКДругомуРаботодателю_ДанныеОЗаработкеДляРасчетаПособий> ПереводКДругомуРаботодателюДанныеОЗаработкеДляРасчетаПособий {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ПереводКДругомуРаботодателю_Начисления> ПереводКДругомуРаботодателюНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ПереводКДругомуРаботодателю_Показатели> ПереводКДругомуРаботодателюПоказатели {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДанныеОДоходах", Comment = "", Synonym = "Данные о доходах")]
    [Table("PerevodKDruhomuRabotodateliu_DannyeODokhodakh")]
    public class ПереводКДругомуРаботодателю_ДанныеОДоходах
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 13.2
        public decimal Сумма {get; set;}
    }
    [Description1C8(Name = "ДанныеОЗаработкеДляРасчетаПособий", Comment = "", Synonym = "Данные о заработке для расчета пособий")]
    [Table("PerevodKDruhomuRabotodateliu_DannyeOZarabotkeDliaRaschetaPosobyi")]
    public class ПереводКДругомуРаботодателю_ДанныеОЗаработкеДляРасчетаПособий
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 13.2
        public decimal Сумма {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("PerevodKDruhomuRabotodateliu_Nachyslenyia")]
    public class ПереводКДругомуРаботодателю_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("PerevodKDruhomuRabotodateliu_Pokazately")]
    public class ПереводКДругомуРаботодателю_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
}

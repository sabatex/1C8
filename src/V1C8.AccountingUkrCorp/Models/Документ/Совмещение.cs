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
    [Table("Sovmeshchenye")]
    [Description1C8(Name = "Совмещение", Comment = "", Synonym = "Совмещение должностей")]
    public class Совмещение:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СовмещающийСотрудник", Comment = "", Synonym = "Совмещающий сотрудник")]
        public Catalogs.Сотрудники СовмещающийСотрудник {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ПричинаСовмещения", Comment = "", Synonym = "Причина совмещения")]
        public Enums.ПричиныСовмещения ПричинаСовмещения {get; set;}
        [Description1C8(Name = "РазмерДоплатыУтвержден", Comment = "", Synonym = "Размер доплаты утвержден")]
        public bool РазмерДоплатыУтвержден {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "РазмерДоплаты", Comment = "", Synonym = "Размер доплаты")]
        // Format 15.3
        public decimal РазмерДоплаты {get; set;}
        [Description1C8(Name = "ФОТ", Comment = "", Synonym = "ФОТ")]
        // Format 15.3
        public decimal ФОТ {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РассчитыватьДоплату", Comment = "", Synonym = "Рассчитывать доплату")]
        public bool РассчитыватьДоплату {get; set;}
        [Description1C8(Name = "СпособРасчетаДоплаты", Comment = "", Synonym = "Способ расчета доплаты")]
        public Enums.СпособыРасчетаДоплатыЗаСовмещение СпособРасчетаДоплаты {get; set;}
        [Description1C8(Name = "ОтсутствующийСотрудник", Comment = "", Synonym = "Отсутствующий сотрудник")]
        public Catalogs.Сотрудники ОтсутствующийСотрудник {get; set;}
        [Description1C8(Name = "СовмещаемаяДолжность", Comment = "", Synonym = "Совмещаемая должность")]
        public Catalogs.ШтатноеРасписание СовмещаемаяДолжность {get; set;}
        [Description1C8(Name = "ПроцентДоплаты", Comment = "", Synonym = "Процент доплаты")]
        // Format 15.2
        public decimal ПроцентДоплаты {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.Совмещение ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ФОТСовмещаемый", Comment = "", Synonym = "ФОТ совмещаемый")]
        public List<Совмещение_ФОТСовмещаемый> СовмещениеФОТСовмещаемый {get;set;}
        [Description1C8(Name = "ФОТСовмещающегоСотрудника", Comment = "", Synonym = "ФОТ совмещающего сотрудника")]
        public List<Совмещение_ФОТСовмещающегоСотрудника> СовмещениеФОТСовмещающегоСотрудника {get;set;}
        [Description1C8(Name = "НачисленияСотрудника", Comment = "", Synonym = "Начисления сотрудника")]
        public List<Совмещение_НачисленияСотрудника> СовмещениеНачисленияСотрудника {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<Совмещение_Показатели> СовмещениеПоказатели {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<Совмещение_ФизическиеЛица> СовмещениеФизическиеЛица {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Совмещение_ДополнительныеРеквизиты> СовмещениеДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ФОТСовмещаемый", Comment = "", Synonym = "ФОТ совмещаемый")]
    [Table("Sovmeshchenye_FOTSovmeshchaemyi")]
    public class Совмещение_ФОТСовмещаемый
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Использовать", Comment = "", Synonym = "Использовать")]
        public bool Использовать {get; set;}
    }
    [Description1C8(Name = "ФОТСовмещающегоСотрудника", Comment = "", Synonym = "ФОТ совмещающего сотрудника")]
    [Table("Sovmeshchenye_FOTSovmeshchaiushchehoSotrudnyka")]
    public class Совмещение_ФОТСовмещающегоСотрудника
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Использовать", Comment = "", Synonym = "Использовать")]
        public bool Использовать {get; set;}
    }
    [Description1C8(Name = "НачисленияСотрудника", Comment = "", Synonym = "Начисления сотрудника")]
    [Table("Sovmeshchenye_NachyslenyiaSotrudnyka")]
    public class Совмещение_НачисленияСотрудника
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
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("Sovmeshchenye_Pokazately")]
    public class Совмещение_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("Sovmeshchenye_FyzycheskyeLytsa")]
    public class Совмещение_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Sovmeshchenye_DopolnytelnyeRekvyzyty")]
    public class Совмещение_ДополнительныеРеквизиты
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

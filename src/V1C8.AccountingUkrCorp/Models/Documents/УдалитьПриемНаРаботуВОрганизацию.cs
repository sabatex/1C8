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
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu")]
    [Description1C8(Name = "УдалитьПриемНаРаботуВОрганизацию", Comment = "(Регл) Прием на работу в организацию", Synonym = "(не используется) Прием на работу в организацию")]
    public class УдалитьПриемНаРаботуВОрганизацию:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьВидЗанятости", Comment = "", Synonym = "Удалить вид занятости")]
        public Enums.УстарелоВидыЗанятости УдалитьВидЗанятости {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УдалитьПриемНаРаботуВОрганизацию_РаботникиОрганизации> УдалитьПриемНаРаботуВОрганизациюРаботникиОрганизации {get;set;}
        [Description1C8(Name = "ОсновныеНачисления", Comment = "", Synonym = "Основные начисления")]
        public List<УдалитьПриемНаРаботуВОрганизацию_ОсновныеНачисления> УдалитьПриемНаРаботуВОрганизациюОсновныеНачисления {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УдалитьПриемНаРаботуВОрганизацию_Взносы> УдалитьПриемНаРаботуВОрганизациюВзносы {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы на ФОТ")]
        public List<УдалитьПриемНаРаботуВОрганизацию_ВзносыФОТ> УдалитьПриемНаРаботуВОрганизациюВзносыФОТ {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<УдалитьПриемНаРаботуВОрганизацию_Удержания> УдалитьПриемНаРаботуВОрганизациюУдержания {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu_RabotnykyOrhanyzatsyy")]
    public class УдалитьПриемНаРаботуВОрганизацию_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
        [Description1C8(Name = "ДатаПриема", Comment = "", Synonym = "Дата приема")]
        public DateTime ДатаПриема {get; set;}
        [Description1C8(Name = "УдалитьТабельныйНомер", Comment = "", Synonym = "Удалить табельный номер")]
        [StringLength(10)]
        public string УдалитьТабельныйНомер {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "БазовыйПериодИндексацииЗарплаты", Comment = "", Synonym = "Базовый период индексации зарплаты")]
        public DateTime БазовыйПериодИндексацииЗарплаты {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПринятНаНовоеРабочееМесто", Comment = "", Synonym = "Принят на новое рабочее место")]
        public bool ПринятНаНовоеРабочееМесто {get; set;}
        [Description1C8(Name = "ДатаСозданияРабочегоМеста", Comment = "", Synonym = "Дата создания рабочего места")]
        public DateTime ДатаСозданияРабочегоМеста {get; set;}
    }
    [Description1C8(Name = "ОсновныеНачисления", Comment = "", Synonym = "Основные начисления")]
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu_OsnovnyeNachyslenyia")]
    public class УдалитьПриемНаРаботуВОрганизацию_ОсновныеНачисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu_Vznosy")]
    public class УдалитьПриемНаРаботуВОрганизацию_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ВидыДействияСНачислением Действие {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы на ФОТ")]
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu_VznosyFOT")]
    public class УдалитьПриемНаРаботуВОрганизацию_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ВидыДействияСНачислением Действие {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("UdalytPryemNaRabotuVOrhanyzatsyiu_Uderzhanyia")]
    public class УдалитьПриемНаРаботуВОрганизацию_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоУдержания ВидРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухУчете", Comment = "", Synonym = "Способ отражения в бух учете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухУчете {get; set;}
    }
}

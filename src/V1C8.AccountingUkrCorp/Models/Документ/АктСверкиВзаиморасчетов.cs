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
    [Table("AktSverkyVzaymoraschetov")]
    [Description1C8(Name = "АктСверкиВзаиморасчетов", Comment = "", Synonym = "Акт сверки расчетов с контрагентом")]
    public class АктСверкиВзаиморасчетов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СверкаСогласована", Comment = "Признак согласования сверки", Synonym = "Сверка согласована")]
        public bool СверкаСогласована {get; set;}
        [Description1C8(Name = "ОстатокНаНачало", Comment = "(Общ) Остаток на начало", Synonym = "Остаток на начало")]
        // Format 15.2
        public decimal ОстатокНаНачало {get; set;}
        [Description1C8(Name = "Расхождение", Comment = "(Общ) Расхождение", Synonym = "Расхождение")]
        // Format 15.2
        public decimal Расхождение {get; set;}
        [Description1C8(Name = "ПредставительОрганизации", Comment = "(Общ)", Synonym = "Представитель организации")]
        public Catalogs.ФизическиеЛица ПредставительОрганизации {get; set;}
        [Description1C8(Name = "ПредставительКонтрагента", Comment = "", Synonym = "Представитель контрагента")]
        public Catalogs.КонтактныеЛица ПредставительКонтрагента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВыводитьПолныеНазванияДокументов", Comment = "", Synonym = "Выводить полные названия документов")]
        public bool ВыводитьПолныеНазванияДокументов {get; set;}
        [Description1C8(Name = "РазбитьПоДоговорам", Comment = "", Synonym = "Разбить по договорам")]
        public bool РазбитьПоДоговорам {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ПоДаннымОрганизации", Comment = "", Synonym = "По данным организации")]
        public List<АктСверкиВзаиморасчетов_ПоДаннымОрганизации> АктСверкиВзаиморасчетовПоДаннымОрганизации {get;set;}
        [Description1C8(Name = "ПоДаннымКонтрагента", Comment = "", Synonym = "По данным контрагента")]
        public List<АктСверкиВзаиморасчетов_ПоДаннымКонтрагента> АктСверкиВзаиморасчетовПоДаннымКонтрагента {get;set;}
        [Description1C8(Name = "СписокСчетов", Comment = "Список счетов, участвующих в расчетах", Synonym = "Список счетов")]
        public List<АктСверкиВзаиморасчетов_СписокСчетов> АктСверкиВзаиморасчетовСписокСчетов {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ПоДаннымОрганизации", Comment = "", Synonym = "По данным организации")]
    [Table("AktSverkyVzaymoraschetov_PoDannymOrhanyzatsyy")]
    public class АктСверкиВзаиморасчетов_ПоДаннымОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
        public DateTime Дата {get; set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Документ {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представления")]
        [StringLength(100)]
        public string Представление {get; set;}
        [Description1C8(Name = "Дебет", Comment = "(Общ) Дебет: увеличение долга контрагента", Synonym = "Дебет")]
        // Format 15.2
        public decimal Дебет {get; set;}
        [Description1C8(Name = "Кредит", Comment = "(Общ) Кредит: увеличение долга организации", Synonym = "Кредит")]
        // Format 15.2
        public decimal Кредит {get; set;}
        [Description1C8(Name = "Договор", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов Договор {get; set;}
    }
    [Description1C8(Name = "ПоДаннымКонтрагента", Comment = "", Synonym = "По данным контрагента")]
    [Table("AktSverkyVzaymoraschetov_PoDannymKontrahenta")]
    public class АктСверкиВзаиморасчетов_ПоДаннымКонтрагента
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
        public DateTime Дата {get; set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Документ {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представления")]
        [StringLength(100)]
        public string Представление {get; set;}
        [Description1C8(Name = "Дебет", Comment = "(Общ) Дебет: увеличение долга контрагента", Synonym = "Дебет")]
        // Format 15.2
        public decimal Дебет {get; set;}
        [Description1C8(Name = "Кредит", Comment = "(Общ) Кредит: увеличение долга организации", Synonym = "Кредит")]
        // Format 15.2
        public decimal Кредит {get; set;}
        [Description1C8(Name = "Договор", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов Договор {get; set;}
    }
    [Description1C8(Name = "СписокСчетов", Comment = "Список счетов, участвующих в расчетах", Synonym = "Список счетов")]
    [Table("AktSverkyVzaymoraschetov_SpysokSchetov")]
    public class АктСверкиВзаиморасчетов_СписокСчетов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Счет", Comment = "", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "УчаствуетВРасчетах", Comment = "Признак использования счета при проведении сверки", Synonym = "Участвует в расчетах")]
        public bool УчаствуетВРасчетах {get; set;}
    }
}

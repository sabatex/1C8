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
    [Table("OperatsyiaNalohovohoUchetaPoNDFL")]
    [Description1C8(Name = "ОперацияНалоговогоУчетаПоНДФЛ", Comment = "", Synonym = "Операция учета НДФЛ")]
    public class ОперацияНалоговогоУчетаПоНДФЛ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ДатаОперации", Comment = "", Synonym = "Дата операции")]
        public DateTime ДатаОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СведенияОДоходах", Comment = "", Synonym = "Сведения о доходах")]
        public List<ОперацияНалоговогоУчетаПоНДФЛ_СведенияОДоходах> ОперацияНалоговогоУчетаПоНДФЛСведенияОДоходах {get;set;}
        [Description1C8(Name = "НДФЛИсчисленный", Comment = "", Synonym = "НДФЛ, исчисленный")]
        public List<ОперацияНалоговогоУчетаПоНДФЛ_НДФЛИсчисленный> ОперацияНалоговогоУчетаПоНДФЛНДФЛИсчисленный {get;set;}
        [Description1C8(Name = "НДФЛУдержанный", Comment = "", Synonym = "НДФЛ удержанный")]
        public List<ОперацияНалоговогоУчетаПоНДФЛ_НДФЛУдержанный> ОперацияНалоговогоУчетаПоНДФЛНДФЛУдержанный {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СведенияОДоходах", Comment = "", Synonym = "Сведения о доходах")]
    [Table("OperatsyiaNalohovohoUchetaPoNDFL_SvedenyiaODokhodakh")]
    public class ОперацияНалоговогоУчетаПоНДФЛ_СведенияОДоходах
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "СуммаДохода", Comment = "", Synonym = "Сумма дохода")]
        // Format 15.2
        public decimal СуммаДохода {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ТерриторииВыполненияРабот ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
        [Description1C8(Name = "НатуральныйКоэффициент", Comment = "", Synonym = "Натуральный коэффициент")]
        public bool НатуральныйКоэффициент {get; set;}
    }
    [Description1C8(Name = "НДФЛИсчисленный", Comment = "", Synonym = "НДФЛ, исчисленный")]
    [Table("OperatsyiaNalohovohoUchetaPoNDFL_NDFLYschyslennyi")]
    public class ОперацияНалоговогоУчетаПоНДФЛ_НДФЛИсчисленный
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ТерриторииВыполненияРабот ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "Доход", Comment = "ВидСтавки", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
    [Description1C8(Name = "НДФЛУдержанный", Comment = "", Synonym = "НДФЛ удержанный")]
    [Table("OperatsyiaNalohovohoUchetaPoNDFL_NDFLUderzhannyi")]
    public class ОперацияНалоговогоУчетаПоНДФЛ_НДФЛУдержанный
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделение {get; set;}
    }
}

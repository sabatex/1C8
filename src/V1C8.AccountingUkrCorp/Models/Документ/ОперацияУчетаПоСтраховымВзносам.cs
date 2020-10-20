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
    [Table("OperatsyiaUchetaPoStrakhovymVznosam")]
    [Description1C8(Name = "ОперацияУчетаПоСтраховымВзносам", Comment = "", Synonym = "Операция учета взносов")]
    public class ОперацияУчетаПоСтраховымВзносам:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцРасчетногоПериода", Comment = "", Synonym = "Месяц расчетного периода")]
        public DateTime МесяцРасчетногоПериода {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СведенияОДоходах", Comment = "", Synonym = "Сведения о доходах")]
        public List<ОперацияУчетаПоСтраховымВзносам_СведенияОДоходах> ОперацияУчетаПоСтраховымВзносамСведенияОДоходах {get;set;}
        [Description1C8(Name = "ПособияПоСоциальномуСтрахованию", Comment = "", Synonym = "Пособия по социальному страхованию")]
        public List<ОперацияУчетаПоСтраховымВзносам_ПособияПоСоциальномуСтрахованию> ОперацияУчетаПоСтраховымВзносамПособияПоСоциальномуСтрахованию {get;set;}
        [Description1C8(Name = "ПособияПоУходуЗаРебенком", Comment = "", Synonym = "Пособия по уходу за ребенком")]
        public List<ОперацияУчетаПоСтраховымВзносам_ПособияПоУходуЗаРебенком> ОперацияУчетаПоСтраховымВзносамПособияПоУходуЗаРебенком {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<ОперацияУчетаПоСтраховымВзносам_ВзносыФОТ> ОперацияУчетаПоСтраховымВзносамВзносыФОТ {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<ОперацияУчетаПоСтраховымВзносам_Взносы> ОперацияУчетаПоСтраховымВзносамВзносы {get;set;}
        [Description1C8(Name = "РасчетыСФондами", Comment = "", Synonym = "Расчеты с фондами")]
        public List<ОперацияУчетаПоСтраховымВзносам_РасчетыСФондами> ОперацияУчетаПоСтраховымВзносамРасчетыСФондами {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СведенияОДоходах", Comment = "", Synonym = "Сведения о доходах")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_SvedenyiaODokhodakh")]
    public class ОперацияУчетаПоСтраховымВзносам_СведенияОДоходах
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Сумма дохода")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "ЭтоОтпускные", Comment = "", Synonym = "Это отпускные")]
        public bool ЭтоОтпускные {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
    }
    [Description1C8(Name = "ПособияПоСоциальномуСтрахованию", Comment = "", Synonym = "Пособия по социальному страхованию")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_PosobyiaPoSotsyalnomuStrakhovanyiu")]
    public class ОперацияУчетаПоСтраховымВзносам_ПособияПоСоциальномуСтрахованию
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидПособияСоциальногоСтрахования", Comment = "", Synonym = "Вид пособия социального страхования")]
        public Enums.ПереченьПособийСоциальногоСтрахования ВидПособияСоциальногоСтрахования {get; set;}
        [Description1C8(Name = "ДатаСтраховогоСлучая", Comment = "Дата начала болезни, дата рождения ребенка и т.п.", Synonym = "Дата страхового случая")]
        public DateTime ДатаСтраховогоСлучая {get; set;}
        [Description1C8(Name = "УчитыватьКакНовыйСтраховойСлучай", Comment = "", Synonym = "Учитывать как новый страховой случай")]
        public bool УчитыватьКакНовыйСтраховойСлучай {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ОплаченныеДни", Comment = "", Synonym = "Оплаченные дни")]
        // Format 5.0
        public long ОплаченныеДни {get; set;}
        [Description1C8(Name = "СуммаВсего", Comment = "", Synonym = "Сумма всего")]
        // Format 15.2
        public decimal СуммаВсего {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "СуммаСверхНорм", Comment = "", Synonym = "Сумма сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНорм {get; set;}
    }
    [Description1C8(Name = "ПособияПоУходуЗаРебенком", Comment = "", Synonym = "Пособия по уходу за ребенком")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_PosobyiaPoUkhoduZaRebenkom")]
    public class ОперацияУчетаПоСтраховымВзносам_ПособияПоУходуЗаРебенком
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НачалоОтпускаПоУходу", Comment = "", Synonym = "Начало отпуска по уходу")]
        public DateTime НачалоОтпускаПоУходу {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ПособиеПоУходуЗаПервымРебенком", Comment = "", Synonym = "Пособие по уходу за первым ребенком")]
        // Format 15.2
        public decimal ПособиеПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "ПособиеПоУходуЗаВторымРебенком", Comment = "", Synonym = "Пособие по уходу за вторым ребенком")]
        // Format 15.2
        public decimal ПособиеПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "ПособиеПоУходуЗаПервымРебенкомСверхНорм", Comment = "", Synonym = "Пособие по уходу за первым ребенком сверх норм")]
        // Format 15.2
        public decimal ПособиеПоУходуЗаПервымРебенкомСверхНорм {get; set;}
        [Description1C8(Name = "ПособиеПоУходуЗаВторымРебенкомСверхНорм", Comment = "", Synonym = "Пособие по уходу за вторым ребенком сверх норм")]
        // Format 15.2
        public decimal ПособиеПоУходуЗаВторымРебенкомСверхНорм {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_VznosyFOT")]
    public class ОперацияУчетаПоСтраховымВзносам_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_Vznosy")]
    public class ОперацияУчетаПоСтраховымВзносам_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "РасчетыСФондами", Comment = "", Synonym = "Расчеты с фондами")]
    [Table("OperatsyiaUchetaPoStrakhovymVznosam_RaschetySFondamy")]
    public class ОперацияУчетаПоСтраховымВзносам_РасчетыСФондами
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "Месяц, которым сумма попадет в отчетность", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
    }
}

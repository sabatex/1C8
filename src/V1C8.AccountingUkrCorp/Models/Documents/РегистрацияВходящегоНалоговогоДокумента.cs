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
    [Table("RehystratsyiaVkhodiashchehoNalohovohoDokumenta")]
    [Description1C8(Name = "РегистрацияВходящегоНалоговогоДокумента", Comment = "(Регл)", Synonym = "Регистрация входящего налогового документа")]
    public class РегистрацияВходящегоНалоговогоДокумента:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "Вид операции", Synonym = "Вид операции")]
        public Enums.ВидыОперацийРегистрацияВходящегоНалоговогоДокумента ВидОперации {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ-основание")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств ДокументОснование {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "Номер документа сторонней организации", Synonym = "Вх. номер")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "Дата документа сторонней организации", Synonym = "Вх. дата")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма документа без НДС (в гривнях)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СуммаНДСДокумента", Comment = "(Общ) Сумма НДС документа (в гривнях)", Synonym = "Сумма НДС Документа")]
        // Format 15.2
        public decimal СуммаНДСДокумента {get; set;}
        [Description1C8(Name = "СчетНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетНДС {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетУчетаВексель", Comment = "(Регл)", Synonym = "Счет расчетов по векселю")]
        public ПланСчетов.Хозрасчетный СчетУчетаВексель {get; set;}
        [Description1C8(Name = "ВексельСубконто1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто1 {get; set;}
        [Description1C8(Name = "ВексельСубконто2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто2 {get; set;}
        [Description1C8(Name = "ВексельСубконто3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто3 {get; set;}
        [Description1C8(Name = "СуммаВозвратнойТары", Comment = "Сумма возвратной тары (в гривнях)", Synonym = "Сумма возвратной тары")]
        // Format 15.2
        public decimal СуммаВозвратнойТары {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС (неподтв.)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "НомерКорректируемогоВходящегоДокумента", Comment = "", Synonym = "Номер корректируемого входящего документа")]
        [StringLength(30)]
        public string НомерКорректируемогоВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаКорректируемогоВходящегоДокумента", Comment = "", Synonym = "Дата корректируемого входящего документа")]
        public DateTime ДатаКорректируемогоВходящегоДокумента {get; set;}
        [Description1C8(Name = "ВключаетсяВУточняющийРасчет", Comment = "", Synonym = "Включается в уточняющий расчет")]
        public bool ВключаетсяВУточняющийРасчет {get; set;}
        [Description1C8(Name = "ВидДокумента", Comment = "", Synonym = "Вид документа")]
        [StringLength(3)]
        public string ВидДокумента {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        [Description1C8(Name = "УточняемыйПериод", Comment = "", Synonym = "Уточняемый период")]
        public DateTime УточняемыйПериод {get; set;}
        [Description1C8(Name = "СчетУчетаКорректировкиНДСКредит", Comment = "", Synonym = "Счет корректировки НДС н/к")]
        public ПланСчетов.Хозрасчетный СчетУчетаКорректировкиНДСКредит {get; set;}
        [Description1C8(Name = "ОснованиеКорректировки", Comment = "(Общ) Любая дополнительная информация", Synonym = "Основание корректировки")]
        public string ОснованиеКорректировки {get; set;}
        [Description1C8(Name = "ТребуетПроверкиВключенияВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Необходимо проверить регистрацию поставщиком в ЕРНН")]
        public bool ТребуетПроверкиВключенияВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "ДатаВключенияВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Дата включения поставщиком в ЕРНН")]
        public DateTime ДатаВключенияВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обос. подразделение")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ВключатьВПриложение8Декларации", Comment = "0 - не включать; 1 - включать в таблицу 1; 2 - включать в таблицу 2", Synonym = "Включать в приложение 8 (Д8) к Декларации по НДС")]
        // Format 1.0
        public long ВключатьВПриложение8Декларации {get; set;}
        [Description1C8(Name = "ОписаниеНарушенияПриложение8Декларации", Comment = "", Synonym = "Описание нарушения")]
        public string ОписаниеНарушенияПриложение8Декларации {get; set;}
        [Description1C8(Name = "ПараметрыДокОтказаПриложение8Декларации", Comment = "", Synonym = "Номер и дата документа, подтверждающего факт отказа")]
        public string ПараметрыДокОтказаПриложение8Декларации {get; set;}
        [Description1C8(Name = "СуммаПриложение8Декларации", Comment = "", Synonym = "Сумма поставки для Приложения 8 без НДС")]
        // Format 15.2
        public decimal СуммаПриложение8Декларации {get; set;}
        [Description1C8(Name = "Сумма7Приложение8Декларации", Comment = "", Synonym = "Сумма поставки (по ставке 7%) для Приложения 8 без НДС")]
        // Format 15.2
        public decimal Сумма7Приложение8Декларации {get; set;}
        [Description1C8(Name = "СуммаНДСПриложение8Декларации", Comment = "", Synonym = "Сумма НДС поставки для Приложения 8")]
        // Format 15.2
        public decimal СуммаНДСПриложение8Декларации {get; set;}
        [Description1C8(Name = "СуммаНДС7Приложение8Декларации", Comment = "", Synonym = "Сумма НДС (по ставке 7%) поставки для Приложения 8")]
        // Format 15.2
        public decimal СуммаНДС7Приложение8Декларации {get; set;}
        [Description1C8(Name = "ЭлектронныйДокумент", Comment = "", Synonym = "Электронный документ")]
        public bool ЭлектронныйДокумент {get; set;}
        [Description1C8(Name = "ДатаПолучения", Comment = "", Synonym = "Дата получения")]
        public DateTime ДатаПолучения {get; set;}
        [Description1C8(Name = "ЕстьXML", Comment = "", Synonym = "Есть XML")]
        public bool ЕстьXML {get; set;}
        [Description1C8(Name = "ДанныеXML", Comment = "", Synonym = "Входящий документ в формате XML")]
        // Сховище значень
        public byte[] ДанныеXML {get; set;}
        [Description1C8(Name = "Звит1С_DOC_ID", Comment = "", Synonym = "ИД документа в FREDO Звіт")]
        [StringLength(40)]
        public string Звит1С_DOC_ID {get; set;}
        [Description1C8(Name = "СчетНДСУсловнаяПродажа", Comment = "(Регл)", Synonym = "Счет НДС (условная продажа)")]
        public ПланСчетов.Хозрасчетный СчетНДСУсловнаяПродажа {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<РегистрацияВходящегоНалоговогоДокумента_Товары> РегистрацияВходящегоНалоговогоДокументаТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("RehystratsyiaVkhodiashchehoNalohovohoDokumenta_Tovary")]
    public class РегистрацияВходящегоНалоговогоДокумента_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НаименованиеТовара", Comment = "(Общ)", Synonym = "Наименование товара")]
        [StringLength(80)]
        public string НаименованиеТовара {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ) Цена продажи без НДС", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ) Сумм без НДС", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "", Synonym = "Сумма взаиморасчетов")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ) Сумма НДС", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ДляХозяйственнойДеятельности", Comment = "", Synonym = "Для хозяйственной деятельности")]
        public bool ДляХозяйственнойДеятельности {get; set;}
        [Description1C8(Name = "ДляОперацийОблагаемыхНДС", Comment = "", Synonym = "Для операций облагаемых НДС")]
        public bool ДляОперацийОблагаемыхНДС {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыйКредит", Comment = "", Synonym = "Статья декларации НДС (н/к)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыйКредит {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка основных фондов")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "ПропорциональныйНДС", Comment = "ст. 199 НК", Synonym = "Пропорционально")]
        public bool ПропорциональныйНДС {get; set;}
    }
}

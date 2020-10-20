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
    [Table("AktObOkazanyyProyzvodstvennykhUsluh")]
    [Description1C8(Name = "АктОбОказанииПроизводственныхУслуг", Comment = "(Общ)", Synonym = "Оказание производственных услуг")]
    public class АктОбОказанииПроизводственныхУслуг:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Упр)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "АвторасчетНДС", Comment = "", Synonym = "Авторасчет НДС")]
        public bool АвторасчетНДС {get; set;}
        [Description1C8(Name = "Получил", Comment = "ФИО представителя контрагента, получившего товары", Synonym = "Представитель контрагента")]
        [StringLength(250)]
        public string Получил {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "(Регл)", Synonym = "Счет НДС (нал. обязательства)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "МестоСоставленияДокумента", Comment = "", Synonym = "Место составления документа")]
        public string МестоСоставленияДокумента {get; set;}
        [Description1C8(Name = "ЕстьАвансДо01042011", Comment = "", Synonym = "Есть валовые расходы, начисленные по авансу до 01.04.2011 р.")]
        public bool ЕстьАвансДо01042011 {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        [Description1C8(Name = "НеОтноситьСебестоимостьЗапасовНаРасходыПоНУ", Comment = "Возможность не относить на расходы себестоимость запасаов, если идет реализации по авансу до 01.04 (в этом случае не покаываются доходы, поэтому есть спорное мнение, что не должны показываться и расходы)", Synonym = "Не относить себестоимость запасов на расходы в налоговом учете")]
        public bool НеОтноситьСебестоимостьЗапасовНаРасходыПоНУ {get; set;}
        [Description1C8(Name = "ПредставительОрганизации", Comment = "(Общ)", Synonym = "Представитель организации")]
        public Catalogs.ФизическиеЛица ПредставительОрганизации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<АктОбОказанииПроизводственныхУслуг_Услуги> АктОбОказанииПроизводственныхУслугУслуги {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("AktObOkazanyyProyzvodstvennykhUsluh_Usluhy")]
    public class АктОбОказанииПроизводственныхУслуг_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "ПлановаяСтоимость", Comment = "(Общ)", Synonym = "Стоимость (плановая)")]
        // Format 15.2
        public decimal ПлановаяСтоимость {get; set;}
        [Description1C8(Name = "СуммаПлановая", Comment = "(Общ)", Synonym = "Сумма (плановая)")]
        // Format 15.2
        public decimal СуммаПлановая {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Упр)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "Спецификация", Comment = "(Общ)", Synonym = "Спецификация")]
        public Catalogs.СпецификацииНоменклатуры Спецификация {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Содержание", Comment = "", Synonym = "Содержание услуги, доп. сведения")]
        [StringLength(1000)]
        public string Содержание {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
}

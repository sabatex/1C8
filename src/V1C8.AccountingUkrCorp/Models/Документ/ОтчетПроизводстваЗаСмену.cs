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
    [Table("OtchetProyzvodstvaZaSmenu")]
    [Description1C8(Name = "ОтчетПроизводстваЗаСмену", Comment = "(Общ)", Synonym = "Отчет производства за смену")]
    public class ОтчетПроизводстваЗаСмену:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ВводитьСтатьиЗатратПоСтрокам", Comment = "(Общ)", Synonym = "Вводить статьи затрат по строкам")]
        public bool ВводитьСтатьиЗатратПоСтрокам {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ВариантВыраженияВнутреннихУслуг", Comment = "", Synonym = "Вариант выражения внутренних услуг")]
        public Enums.ВариантВыраженияВнутреннихУслуг ВариантВыраженияВнутреннихУслуг {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ИспользоватьМатериалы", Comment = "", Synonym = "Списать материалы")]
        public bool ИспользоватьМатериалы {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Продукция", Comment = "(Общ)", Synonym = "Продукция")]
        public List<ОтчетПроизводстваЗаСмену_Продукция> ОтчетПроизводстваЗаСменуПродукция {get;set;}
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<ОтчетПроизводстваЗаСмену_Услуги> ОтчетПроизводстваЗаСменуУслуги {get;set;}
        [Description1C8(Name = "ВозвратныеОтходы", Comment = "(Общ)", Synonym = "Возвратные отходы")]
        public List<ОтчетПроизводстваЗаСмену_ВозвратныеОтходы> ОтчетПроизводстваЗаСменуВозвратныеОтходы {get;set;}
        [Description1C8(Name = "Материалы", Comment = "(Общ)", Synonym = "Материалы")]
        public List<ОтчетПроизводстваЗаСмену_Материалы> ОтчетПроизводстваЗаСменуМатериалы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Продукция", Comment = "(Общ)", Synonym = "Продукция")]
    [Table("OtchetProyzvodstvaZaSmenu_Produktsyia")]
    public class ОтчетПроизводстваЗаСмену_Продукция
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ПлановаяСтоимость", Comment = "(Общ)", Synonym = "Стоимость (плановая)")]
        // Format 15.2
        public decimal ПлановаяСтоимость {get; set;}
        [Description1C8(Name = "СуммаПлановая", Comment = "(Общ)", Synonym = "Сумма (плановая)")]
        // Format 15.2
        public decimal СуммаПлановая {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Спецификация", Comment = "(Общ)", Synonym = "Спецификация")]
        public Catalogs.СпецификацииНоменклатуры Спецификация {get; set;}
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("OtchetProyzvodstvaZaSmenu_Usluhy")]
    public class ОтчетПроизводстваЗаСмену_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "СуммаПлановая", Comment = "(Общ)", Synonym = "Сумма (плановая)")]
        // Format 15.2
        public decimal СуммаПлановая {get; set;}
        [Description1C8(Name = "ПлановаяСтоимость", Comment = "(Общ)", Synonym = "Стоимость (плановая)")]
        // Format 15.2
        public decimal ПлановаяСтоимость {get; set;}
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "Спецификация", Comment = "(Общ)", Synonym = "Спецификация")]
        public Catalogs.СпецификацииНоменклатуры Спецификация {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. услуг")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
    [Description1C8(Name = "ВозвратныеОтходы", Comment = "(Общ)", Synonym = "Возвратные отходы")]
    [Table("OtchetProyzvodstvaZaSmenu_VozvratnyeOtkhody")]
    public class ОтчетПроизводстваЗаСмену_ВозвратныеОтходы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "(Регл)", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
    }
    [Description1C8(Name = "Материалы", Comment = "(Общ)", Synonym = "Материалы")]
    [Table("OtchetProyzvodstvaZaSmenu_Materyaly")]
    public class ОтчетПроизводстваЗаСмену_Материалы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Регл)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость (НУ)")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
}

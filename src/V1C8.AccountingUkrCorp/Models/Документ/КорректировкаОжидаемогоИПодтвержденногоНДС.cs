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
    [Table("KorrektyrovkaOzhydaemohoYPodtverzhdennohoNDS")]
    [Description1C8(Name = "КорректировкаОжидаемогоИПодтвержденногоНДС", Comment = "(Регл)", Synonym = "Корректировка ожидаемого и подтвержденного НДС")]
    public class КорректировкаОжидаемогоИПодтвержденногоНДС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "НДССубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто1 {get; set;}
        [Description1C8(Name = "НДССубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто2 {get; set;}
        [Description1C8(Name = "НДССубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто3 {get; set;}
        [Description1C8(Name = "СчетУчетаДоходов", Comment = "", Synonym = "Счет доходов")]
        public ПланСчетов.Хозрасчетный СчетУчетаДоходов {get; set;}
        [Description1C8(Name = "ДоходыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто1 {get; set;}
        [Description1C8(Name = "ДоходыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто2 {get; set;}
        [Description1C8(Name = "ДоходыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто3 {get; set;}
        [Description1C8(Name = "СчетУчетаЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗатрат {get; set;}
        [Description1C8(Name = "ЗатратыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто1 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто2 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто3 {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СчетУчетаКорректировкиНДСКредит", Comment = "", Synonym = "Счет корректировки НДС н/к:")]
        public ПланСчетов.Хозрасчетный СчетУчетаКорректировкиНДСКредит {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ПриобретенияПодтвержденный", Comment = "", Synonym = "Приобретения подтвержденный НДС")]
        public List<КорректировкаОжидаемогоИПодтвержденногоНДС_ПриобретенияПодтвержденный> КорректировкаОжидаемогоИПодтвержденногоНДСПриобретенияПодтвержденный {get;set;}
        [Description1C8(Name = "ПриобретенияОжидаемый", Comment = "", Synonym = "Приобретения ожидаемый НДС")]
        public List<КорректировкаОжидаемогоИПодтвержденногоНДС_ПриобретенияОжидаемый> КорректировкаОжидаемогоИПодтвержденногоНДСПриобретенияОжидаемый {get;set;}
        [Description1C8(Name = "ПродажиПодтвержденный", Comment = "", Synonym = "Продажи подтвержденный")]
        public List<КорректировкаОжидаемогоИПодтвержденногоНДС_ПродажиПодтвержденный> КорректировкаОжидаемогоИПодтвержденногоНДСПродажиПодтвержденный {get;set;}
        [Description1C8(Name = "ПродажиОжидаемый", Comment = "", Synonym = "Продажи ожидаемый")]
        public List<КорректировкаОжидаемогоИПодтвержденногоНДС_ПродажиОжидаемый> КорректировкаОжидаемогоИПодтвержденногоНДСПродажиОжидаемый {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ПриобретенияПодтвержденный", Comment = "", Synonym = "Приобретения подтвержденный НДС")]
    [Table("KorrektyrovkaOzhydaemohoYPodtverzhdennohoNDS_PryobretenyiaPodtverzhdennyi")]
    public class КорректировкаОжидаемогоИПодтвержденногоНДС_ПриобретенияПодтвержденный
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "СобытиеНДС", Comment = "", Synonym = "Событие НДС")]
        public Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений СобытиеНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДляХозяйственнойДеятельности", Comment = "", Synonym = "Хоз. деятельность")]
        public bool ДляХозяйственнойДеятельности {get; set;}
        [Description1C8(Name = "ДляОперацийОблагаемыхНДС", Comment = "", Synonym = "Обл. НДС")]
        public bool ДляОперацийОблагаемыхНДС {get; set;}
        [Description1C8(Name = "ВидОстатка", Comment = "", Synonym = "Вид остатка")]
        public Enums.ВидыОстатковНДСПриобретенийПодтвержденный ВидОстатка {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка ОФ")]
        public bool Амортизируется {get; set;}
    }
    [Description1C8(Name = "ПриобретенияОжидаемый", Comment = "", Synonym = "Приобретения ожидаемый НДС")]
    [Table("KorrektyrovkaOzhydaemohoYPodtverzhdennohoNDS_PryobretenyiaOzhydaemyi")]
    public class КорректировкаОжидаемогоИПодтвержденногоНДС_ПриобретенияОжидаемый
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "СобытиеНДС", Comment = "", Synonym = "Событие НДС")]
        public Enums.СобытияОжидаемыйИПодтвержденныйНДСПриобретений СобытиеНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДляХозяйственнойДеятельности", Comment = "", Synonym = "Хоз. деятельность")]
        public bool ДляХозяйственнойДеятельности {get; set;}
        [Description1C8(Name = "ДляОперацийОблагаемыхНДС", Comment = "", Synonym = "Обл. НДС")]
        public bool ДляОперацийОблагаемыхНДС {get; set;}
        [Description1C8(Name = "ВидОстатка", Comment = "", Synonym = "Вид остатка")]
        public Enums.ВидыОстатковНДСПриобретенийОжидаемый ВидОстатка {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка ОФ")]
        public bool Амортизируется {get; set;}
    }
    [Description1C8(Name = "ПродажиПодтвержденный", Comment = "", Synonym = "Продажи подтвержденный")]
    [Table("KorrektyrovkaOzhydaemohoYPodtverzhdennohoNDS_ProdazhyPodtverzhdennyi")]
    public class КорректировкаОжидаемогоИПодтвержденногоНДС_ПродажиПодтвержденный
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "СобытиеНДС", Comment = "", Synonym = "Событие НДС")]
        public Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж СобытиеНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ВидОстатка", Comment = "", Synonym = "Вид остатка")]
        public Enums.ВидыОстатковНДСПродажПодтвержденный ВидОстатка {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
    }
    [Description1C8(Name = "ПродажиОжидаемый", Comment = "", Synonym = "Продажи ожидаемый")]
    [Table("KorrektyrovkaOzhydaemohoYPodtverzhdennohoNDS_ProdazhyOzhydaemyi")]
    public class КорректировкаОжидаемогоИПодтвержденногоНДС_ПродажиОжидаемый
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "СобытиеНДС", Comment = "", Synonym = "Событие НДС")]
        public Enums.СобытияОжидаемыйИПодтвержденныйНДСПродаж СобытиеНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ВидОстатка", Comment = "", Synonym = "Вид остатка")]
        public Enums.ВидыОстатковНДСПродажОжидаемый ВидОстатка {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
    }
}

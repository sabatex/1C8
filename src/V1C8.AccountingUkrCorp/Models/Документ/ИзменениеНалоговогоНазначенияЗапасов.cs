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
    [Table("YzmenenyeNalohovohoNaznachenyiaZapasov")]
    [Description1C8(Name = "ИзменениеНалоговогоНазначенияЗапасов", Comment = "(Регл)", Synonym = "Изменение налогового назначения запасов")]
    public class ИзменениеНалоговогоНазначенияЗапасов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СчетУчетаЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗатрат {get; set;}
        [Description1C8(Name = "ЗатратыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто1 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто2 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто3 {get; set;}
        [Description1C8(Name = "СчетУчетаНДС_НО", Comment = "", Synonym = "Счет НДС (н/о)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС_НО {get; set;}
        [Description1C8(Name = "СчетУчетаКорректировкиНДСКредит", Comment = "", Synonym = "Счет корректировки НДС н/к")]
        public ПланСчетов.Хозрасчетный СчетУчетаКорректировкиНДСКредит {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ИзменениеНалоговогоНазначенияЗапасов_Товары> ИзменениеНалоговогоНазначенияЗапасовТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("YzmenenyeNalohovohoNaznachenyiaZapasov_Tovary")]
    public class ИзменениеНалоговогоНазначенияЗапасов_Товары
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
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеНовое", Comment = "", Synonym = "Налоговое назначение новое")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеНовое {get; set;}
        [Description1C8(Name = "МетодКорректировкиНалоговогоКредита", Comment = "", Synonym = "Метод корректировки налогового кредита")]
        public Enums.МетодыКорректировкиНалоговогоКредита МетодКорректировкиНалоговогоКредита {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
    }
}

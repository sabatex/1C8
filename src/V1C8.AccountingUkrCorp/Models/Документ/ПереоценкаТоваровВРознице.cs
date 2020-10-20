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
    [Table("PereotsenkaTovarovVRoznytse")]
    [Description1C8(Name = "ПереоценкаТоваровВРознице", Comment = "", Synonym = "Переоценка товаров в рознице")]
    public class ПереоценкаТоваровВРознице:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "ДокументУстановкиЦен", Comment = "", Synonym = "Документ установки цен")]
        public Документ.УстановкаЦенНоменклатуры ДокументУстановкиЦен {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<ПереоценкаТоваровВРознице_Товары> ПереоценкаТоваровВРозницеТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("PereotsenkaTovarovVRoznytse_Tovary")]
    public class ПереоценкаТоваровВРознице_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ЦенаВРозницеСтарая", Comment = "", Synonym = "Старая цена реализации")]
        // Format 15.2
        public decimal ЦенаВРозницеСтарая {get; set;}
        [Description1C8(Name = "ЦенаВРознице", Comment = "Розничная цена в розничной торговле, цена продажи при поступлении на комиссию по 'жесткой' схеме", Synonym = "Цена в рознице")]
        // Format 15.2
        public decimal ЦенаВРознице {get; set;}
        [Description1C8(Name = "СтавкаНДСВРознице", Comment = "(Общ)", Synonym = "Ставка НДС в рознице")]
        public Enums.СтавкиНДС СтавкаНДСВРознице {get; set;}
        [Description1C8(Name = "СуммаПереоценки", Comment = "(Общ)", Synonym = "Сумма переоценки")]
        // Format 15.2
        public decimal СуммаПереоценки {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}

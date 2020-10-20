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
    [Table("SpetsyfykatsyyNomenklatury")]
    [Description1C8(Name = "СпецификацииНоменклатуры", Comment = "", Synonym = "Спецификации номенклатуры")]
    public class СпецификацииНоменклатуры:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ИсходныеКомплектующие", Comment = "", Synonym = "Исходные комплектующие")]
        public List<СпецификацииНоменклатуры_ИсходныеКомплектующие> СпецификацииНоменклатурыИсходныеКомплектующие {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ИсходныеКомплектующие", Comment = "", Synonym = "Исходные комплектующие")]
    [Table("SpetsyfykatsyyNomenklatury_YskhodnyeKomplektuiushchye")]
    public class СпецификацииНоменклатуры_ИсходныеКомплектующие
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Ед.")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "К.")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
    }
}

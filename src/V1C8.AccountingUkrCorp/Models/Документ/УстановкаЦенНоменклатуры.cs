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
    [Table("UstanovkaTsenNomenklatury")]
    [Description1C8(Name = "УстановкаЦенНоменклатуры", Comment = "", Synonym = "Установка цен номенклатуры")]
    public class УстановкаЦенНоменклатуры:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ТипЦен", Comment = "", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "НеПроводитьНулевыеЗначения", Comment = "", Synonym = "Не проводить нулевые значения")]
        public bool НеПроводитьНулевыеЗначения {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
        [StringLength(200)]
        public string Информация {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<УстановкаЦенНоменклатуры_Товары> УстановкаЦенНоменклатурыТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("UstanovkaTsenNomenklatury_Tovary")]
    public class УстановкаЦенНоменклатуры_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Цена", Comment = "", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
    }
}

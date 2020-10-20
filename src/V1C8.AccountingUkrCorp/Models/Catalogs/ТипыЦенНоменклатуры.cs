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
    [Table("TypyTsenNomenklatury")]
    [Description1C8(Name = "ТипыЦенНоменклатуры", Comment = "", Synonym = "Типы цен номенклатуры")]
    public class ТипыЦенНоменклатуры:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ВалютаЦены", Comment = "", Synonym = "Валюта цены по умолчанию")]
    public Catalogs.Валюты ВалютаЦены {get; set;}
    [Description1C8(Name = "ЦенаВключаетНДС", Comment = "", Synonym = "Цена включает НДС")]
    public bool ЦенаВключаетНДС {get; set;}
    [Description1C8(Name = "ПорядокОкругления", Comment = "", Synonym = "Округлять до")]
    public Enums.ПорядкиОкругления ПорядокОкругления {get; set;}
    [Description1C8(Name = "ОкруглятьВБольшуюСторону", Comment = "", Synonym = "Метод округления")]
    public bool ОкруглятьВБольшуюСторону {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

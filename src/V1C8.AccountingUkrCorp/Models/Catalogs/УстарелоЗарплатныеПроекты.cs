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
    [Table("UstareloZarplatnyeProekty")]
    [Description1C8(Name = "УстарелоЗарплатныеПроекты", Comment = "", Synonym = "ѳ(устарело) Зарплатные проекты")]
    public class УстарелоЗарплатныеПроекты:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
    public Catalogs.Организации Организация {get; set;}
    [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
    public Catalogs.Контрагенты Банк {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    public List<УстарелоЗарплатныеПроекты_ДополнительныеРеквизиты> УстарелоЗарплатныеПроектыДополнительныеРеквизиты
    #endregion tables
    }
}

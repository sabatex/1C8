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
    [Table("StatyDokhodov")]
    [Description1C8(Name = "СтатьиДоходов", Comment = "(Регл)", Synonym = "Статьи доходов")]
    public class СтатьиДоходов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "СтатьяДекларацииПоНалогуНаПрибыль", Comment = "", Synonym = "Ст. декл. по налогу на прибыль (до 01.01.2015)")]
    public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоНалогуНаПрибыль {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

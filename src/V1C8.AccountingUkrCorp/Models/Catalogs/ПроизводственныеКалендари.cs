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
    [Table("ProyzvodstvennyeKalendary")]
    [Description1C8(Name = "ПроизводственныеКалендари", Comment = "", Synonym = "Производственные календари")]
    public class ПроизводственныеКалендари:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "БазовыйКалендарь", Comment = "", Synonym = "Базовый календарь")]
    public Catalogs.ПроизводственныеКалендари БазовыйКалендарь {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

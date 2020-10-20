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
    [Table("MestaRaboty")]
    [Description1C8(Name = "МестаРаботы", Comment = "", Synonym = "Места работы")]
    public class МестаРаботы:CatalogItem
    {
    #region реквізити
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    public List<МестаРаботы_Начисления> МестаРаботыНачисления
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    public List<МестаРаботы_Показатели> МестаРаботыПоказатели
    #endregion tables
    }
}

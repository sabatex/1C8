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
    [Table("TypovyeOperatsyy")]
    [Description1C8(Name = "ТиповыеОперации", Comment = "", Synonym = "Типовые операции")]
    public class ТиповыеОперации:CatalogItem
    {
    #region реквізити
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Хозрасчетный", Comment = "", Synonym = "Хозрасчетный")]
    public List<ТиповыеОперации_Хозрасчетный> ТиповыеОперацииХозрасчетный
    [Description1C8(Name = "ДвиженияРегистров", Comment = "", Synonym = "Движения регистров")]
    public List<ТиповыеОперации_ДвиженияРегистров> ТиповыеОперацииДвиженияРегистров
    #endregion tables
    }
}

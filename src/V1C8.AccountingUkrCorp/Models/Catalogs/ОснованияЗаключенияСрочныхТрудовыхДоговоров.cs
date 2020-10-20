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
    [Table("OsnovanyiaZakliuchenyiaSrochnykhTrudovykhDohovorov")]
    [Description1C8(Name = "ОснованияЗаключенияСрочныхТрудовыхДоговоров", Comment = "", Synonym = "Основания заключения срочных трудовых договоров")]
    public class ОснованияЗаключенияСрочныхТрудовыхДоговоров:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ТекстОснования", Comment = "", Synonym = "Текст для приказа")]
    [StringLength(250)]
    public string ТекстОснования {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

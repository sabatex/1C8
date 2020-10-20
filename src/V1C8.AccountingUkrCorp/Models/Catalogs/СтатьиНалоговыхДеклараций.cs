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
    [Table("StatyNalohovykhDeklaratsyi")]
    [Description1C8(Name = "СтатьиНалоговыхДеклараций", Comment = "(Регл)", Synonym = "Статьи налоговых деклараций")]
    public class СтатьиНалоговыхДеклараций:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ВидНалоговойДекларации", Comment = "", Synonym = "Вид декларации")]
    public Enums.ВидыНалоговыхДеклараций ВидНалоговойДекларации {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

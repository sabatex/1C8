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
    [Table("NalohovyeHruppyOsnovnykhSredstv")]
    [Description1C8(Name = "НалоговыеГруппыОсновныхСредств", Comment = "", Synonym = "Налоговые группы основных средств")]
    public class НалоговыеГруппыОсновныхСредств:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ВидНалоговойГруппыНА", Comment = "", Synonym = "Вид налоговой группы")]
    public Enums.ВидыНалоговыхГруппНА ВидНалоговойГруппыНА {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

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
    [Table("StatyOtsrochennykhNalohovykhAktyvovYObiazatelstv")]
    [Description1C8(Name = "СтатьиОтсроченныхНалоговыхАктивовИОбязательств", Comment = "(Регл)", Synonym = "Статьи отсроченных налоговых активов и обязательств")]
    public class СтатьиОтсроченныхНалоговыхАктивовИОбязательств:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "СчетБУ", Comment = "Счет для оценки статьи по бух. учету", Synonym = "Счет оценки по бух. учету")]
    public ПланСчетов.Хозрасчетный СчетБУ {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

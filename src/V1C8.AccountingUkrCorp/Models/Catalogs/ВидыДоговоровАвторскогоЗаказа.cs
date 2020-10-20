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
    [Table("VydyDohovorovAvtorskohoZakaza")]
    [Description1C8(Name = "ВидыДоговоровАвторскогоЗаказа", Comment = "", Synonym = "Виды авторских договоров")]
    public class ВидыДоговоровАвторскогоЗаказа:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "КодДоходаНДФЛ", Comment = "", Synonym = "Код дохода НДФЛ")]
    public Catalogs.ВидыДоходовНДФЛ КодДоходаНДФЛ {get; set;}
    [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
    public Enums.ВидыЕСВ ВидЕСВ {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

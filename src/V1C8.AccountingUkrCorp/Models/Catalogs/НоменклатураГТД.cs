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
    [Table("NomenklaturaHTD")]
    [Description1C8(Name = "НоменклатураГТД", Comment = "", Synonym = "Коды номенклатуры для НН")]
    public class НоменклатураГТД:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код для НН")]
    public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
    [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
    public Catalogs.НомераГТД НомерГТД {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

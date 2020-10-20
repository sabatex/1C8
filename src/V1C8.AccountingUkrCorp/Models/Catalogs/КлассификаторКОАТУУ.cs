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
    [Table("KlassyfykatorKOATUU")]
    [Description1C8(Name = "КлассификаторКОАТУУ", Comment = "(Общ)", Synonym = "Классификатор КОАТУУ")]
    public class КлассификаторКОАТУУ:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "НалоговаяИнспекция", Comment = "(Общ)", Synonym = "Налоговая инспекция")]
    public Catalogs.НалоговыеИнспекции НалоговаяИнспекция {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

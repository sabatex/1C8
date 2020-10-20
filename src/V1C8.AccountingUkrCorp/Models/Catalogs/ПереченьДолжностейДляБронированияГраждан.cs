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
    [Table("PerechenDolzhnosteiDliaBronyrovanyiaHrazhdan")]
    [Description1C8(Name = "ПереченьДолжностейДляБронированияГраждан", Comment = "", Synonym = "Перечень должностей для бронирования")]
    public class ПереченьДолжностейДляБронированияГраждан:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ОписаниеПункта", Comment = "", Synonym = "Описание пункта")]
    public string ОписаниеПункта {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}

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
    [Table("SpetsyfykatsyyNomenklatury")]
    [Description1C8(Name = "СпецификацииНоменклатуры", Comment = "", Synonym = "Спецификации номенклатуры")]
    public class СпецификацииНоменклатуры:EnumItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
    // Format 15.3
    public decimal Количество {get; set;}
    [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
    public DBNull ЕдиницаИзмерения {get; set;}
    [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
    // Format 10.3
    public decimal Коэффициент {get; set;}
    #endregion реквізити
    }
}

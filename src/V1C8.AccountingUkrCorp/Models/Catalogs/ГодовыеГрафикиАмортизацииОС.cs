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
    [Table("HodovyeHrafykyAmortyzatsyyOS")]
    [Description1C8(Name = "ГодовыеГрафикиАмортизацииОС", Comment = "", Synonym = "Годовые графики амортизации ОС")]
    public class ГодовыеГрафикиАмортизацииОС:CatalogItem
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
    [Description1C8(Name = "Коэффициент1", Comment = "", Synonym = "Январь")]
    // Format 6.3
    public decimal Коэффициент1 {get; set;}
    [Description1C8(Name = "Коэффициент2", Comment = "", Synonym = "Февраль")]
    // Format 6.3
    public decimal Коэффициент2 {get; set;}
    [Description1C8(Name = "Коэффициент3", Comment = "", Synonym = "Март")]
    // Format 6.3
    public decimal Коэффициент3 {get; set;}
    [Description1C8(Name = "Коэффициент4", Comment = "", Synonym = "Апрель")]
    // Format 6.3
    public decimal Коэффициент4 {get; set;}
    [Description1C8(Name = "Коэффициент5", Comment = "", Synonym = "Май")]
    // Format 6.3
    public decimal Коэффициент5 {get; set;}
    [Description1C8(Name = "Коэффициент6", Comment = "", Synonym = "Июнь")]
    // Format 6.3
    public decimal Коэффициент6 {get; set;}
    [Description1C8(Name = "Коэффициент7", Comment = "", Synonym = "Июль")]
    // Format 6.3
    public decimal Коэффициент7 {get; set;}
    [Description1C8(Name = "Коэффициент8", Comment = "", Synonym = "Август")]
    // Format 6.3
    public decimal Коэффициент8 {get; set;}
    [Description1C8(Name = "Коэффициент9", Comment = "", Synonym = "Сентябрь")]
    // Format 6.3
    public decimal Коэффициент9 {get; set;}
    [Description1C8(Name = "Коэффициент10", Comment = "", Synonym = "Октябрь")]
    // Format 6.3
    public decimal Коэффициент10 {get; set;}
    [Description1C8(Name = "Коэффициент11", Comment = "", Synonym = "Ноябрь")]
    // Format 6.3
    public decimal Коэффициент11 {get; set;}
    [Description1C8(Name = "Коэффициент12", Comment = "", Synonym = "Декабрь")]
    // Format 6.3
    public decimal Коэффициент12 {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    }
}

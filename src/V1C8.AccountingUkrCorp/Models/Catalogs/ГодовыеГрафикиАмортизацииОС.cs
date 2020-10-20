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
    public class ГодовыеГрафикиАмортизацииОС:EnumItem
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
    public DBNull Коэффициент1 {get; set;}
    [Description1C8(Name = "Коэффициент2", Comment = "", Synonym = "Февраль")]
    public DBNull Коэффициент2 {get; set;}
    [Description1C8(Name = "Коэффициент3", Comment = "", Synonym = "Март")]
    public DBNull Коэффициент3 {get; set;}
    [Description1C8(Name = "Коэффициент4", Comment = "", Synonym = "Апрель")]
    public DBNull Коэффициент4 {get; set;}
    [Description1C8(Name = "Коэффициент5", Comment = "", Synonym = "Май")]
    public DBNull Коэффициент5 {get; set;}
    [Description1C8(Name = "Коэффициент6", Comment = "", Synonym = "Июнь")]
    public DBNull Коэффициент6 {get; set;}
    [Description1C8(Name = "Коэффициент7", Comment = "", Synonym = "Июль")]
    public DBNull Коэффициент7 {get; set;}
    [Description1C8(Name = "Коэффициент8", Comment = "", Synonym = "Август")]
    public DBNull Коэффициент8 {get; set;}
    [Description1C8(Name = "Коэффициент9", Comment = "", Synonym = "Сентябрь")]
    public DBNull Коэффициент9 {get; set;}
    [Description1C8(Name = "Коэффициент10", Comment = "", Synonym = "Октябрь")]
    public DBNull Коэффициент10 {get; set;}
    [Description1C8(Name = "Коэффициент11", Comment = "", Synonym = "Ноябрь")]
    public DBNull Коэффициент11 {get; set;}
    [Description1C8(Name = "Коэффициент12", Comment = "", Synonym = "Декабрь")]
    public DBNull Коэффициент12 {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    }
}

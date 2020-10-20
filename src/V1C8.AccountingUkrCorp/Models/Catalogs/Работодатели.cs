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
    [Table("Rabotodately")]
    [Description1C8(Name = "Работодатели", Comment = "", Synonym = "Работодатели")]
    public class Работодатели
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "КодПоЕДРПОУ", Comment = "", Synonym = "Код по ЕДРПОУ")]
    [StringLength(10)]
    public string КодПоЕДРПОУ {get; set;}
    #endregion реквізити
    }
}

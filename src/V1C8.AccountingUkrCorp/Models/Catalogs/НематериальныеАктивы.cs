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
    [Table("NemateryalnyeAktyvy")]
    [Description1C8(Name = "НематериальныеАктивы", Comment = "", Synonym = "Нематериальные активы")]
    public class НематериальныеАктивы:EnumItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
    [StringLength(1000)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ПрочиеСведения", Comment = "", Synonym = "Прочие сведения")]
    public string ПрочиеСведения {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
    public DBNull НалоговоеНазначение {get; set;}
    #endregion реквізити
    }
}

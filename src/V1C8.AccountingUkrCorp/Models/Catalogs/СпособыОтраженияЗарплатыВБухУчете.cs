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
    [Table("SposobyOtrazhenyiaZarplatyVBukhUchete")]
    [Description1C8(Name = "СпособыОтраженияЗарплатыВБухУчете", Comment = "", Synonym = "Способы отражения зарплаты")]
    public class СпособыОтраженияЗарплатыВБухУчете:EnumItem
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
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    [StringLength(1024)]
    public string Описание {get; set;}
    [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
    public DBNull СчетУчета {get; set;}
    [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто1")]
    public DBNull Субконто1 {get; set;}
    [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто2")]
    public DBNull Субконто2 {get; set;}
    [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто3")]
    public DBNull Субконто3 {get; set;}
    [Description1C8(Name = "РежимУчетаВзносов", Comment = "0 - совпадает с зарплатй, 1 - все взносы на отдельной статье", Synonym = "Режим учета взносов")]
    // Format 10.0
    public long РежимУчетаВзносов {get; set;}
    [Description1C8(Name = "ЕстьПрочиеОперации", Comment = "", Synonym = "Есть прочие операции")]
    public bool ЕстьПрочиеОперации {get; set;}
    [Description1C8(Name = "СчетУчетаВзносов", Comment = "", Synonym = "Счет учета взносов")]
    public DBNull СчетУчетаВзносов {get; set;}
    [Description1C8(Name = "Субконто1Взносов", Comment = "", Synonym = "Субконто1 взносов")]
    public DBNull Субконто1Взносов {get; set;}
    [Description1C8(Name = "Субконто2Взносов", Comment = "", Synonym = "Субконто2 взносов")]
    public DBNull Субконто2Взносов {get; set;}
    [Description1C8(Name = "Субконто3Взносов", Comment = "", Synonym = "Субконто3 взносов")]
    public DBNull Субконто3Взносов {get; set;}
    [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат (до 01.01.2015)")]
    public DBNull НалоговоеНазначениеДоходовИЗатрат {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
    public DBNull НалоговоеНазначение {get; set;}
    #endregion реквізити
    }
}

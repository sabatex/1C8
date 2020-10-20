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
    [Table("VersyyRasshyrenyi")]
    [Description1C8(Name = "ВерсииРасширений", Comment = "", Synonym = "Версии расширений")]
    public class ВерсииРасширений:CatalogItem
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
    [Description1C8(Name = "ОписаниеМетаданных", Comment = "", Synonym = "Описание метаданных")]
    public string ОписаниеМетаданных {get; set;}
    [Description1C8(Name = "ПоследняяДатаДобавленияВторойВерсии", Comment = "", Synonym = "Последняя дата добавления второй версии")]
    public DateTime ПоследняяДатаДобавленияВторойВерсии {get; set;}
    [Description1C8(Name = "ДатаПервогоВходаПослеУдаленияВсехРасширений", Comment = "", Synonym = "Дата первого входа после удаления всех расширений")]
    public DateTime ДатаПервогоВходаПослеУдаленияВсехРасширений {get; set;}
    #endregion реквізити
    }
}

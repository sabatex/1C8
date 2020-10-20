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
    [Table("ProfylyHruppDostupa")]
    [Description1C8(Name = "ПрофилиГруппДоступа", Comment = "", Synonym = "Профили групп доступа")]
    public class ПрофилиГруппДоступа:EnumItem
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
    [Description1C8(Name = "ИдентификаторПоставляемыхДанных", Comment = "", Synonym = "Идентификатор поставляемых данных")]
    public Guid ИдентификаторПоставляемыхДанных {get; set;}
    [Description1C8(Name = "ПоставляемыйПрофильИзменен", Comment = "", Synonym = "Поставляемый профиль изменен")]
    public bool ПоставляемыйПрофильИзменен {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    }
}

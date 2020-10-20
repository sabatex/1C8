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
    [Table("HruppyVneshnykhPolzovatelei")]
    [Description1C8(Name = "ГруппыВнешнихПользователей", Comment = "", Synonym = "Группы внешних пользователей")]
    public class ГруппыВнешнихПользователей:CatalogItem
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
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "УдалитьТипОбъектовАвторизации", Comment = "В качестве типа используется пустая ссылка", Synonym = "(не используется) Тип объектов авторизации")]
    [StringLength(10)]
    public string УдалитьТипОбъектовАвторизации {get; set;}
    [Description1C8(Name = "ВсеОбъектыАвторизации", Comment = "", Synonym = "Все")]
    public bool ВсеОбъектыАвторизации {get; set;}
    #endregion реквізити
    }
}

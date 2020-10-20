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
    [Table("RehlamentyrovannyeOtchety")]
    [Description1C8(Name = "РегламентированныеОтчеты", Comment = "", Synonym = "Регламентированные отчеты")]
    public class РегламентированныеОтчеты:EnumItem
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
    [Description1C8(Name = "ИсточникОтчета", Comment = "", Synonym = "Источник отчета")]
    [StringLength(255)]
    public string ИсточникОтчета {get; set;}
    [Description1C8(Name = "УдалитьНеПоказыватьВСписке", Comment = "", Synonym = "(неиспользуется)Удалить не показывать в списке")]
    public bool УдалитьНеПоказыватьВСписке {get; set;}
    [Description1C8(Name = "Описание", Comment = "Любая дополнительная информация", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "Периоды", Comment = "", Synonym = "Периоды")]
    // Сховище значень
    public byte[] Периоды {get; set;}
    [Description1C8(Name = "ВнешнийОтчетИспользовать", Comment = "", Synonym = "Использовать внешний отчет")]
    public bool ВнешнийОтчетИспользовать {get; set;}
    [Description1C8(Name = "ВнешнийОтчетХранилище", Comment = "", Synonym = "Хранилище с внешним отчетом")]
    // Сховище значень
    public byte[] ВнешнийОтчетХранилище {get; set;}
    [Description1C8(Name = "ВнешнийОтчетВерсия", Comment = "", Synonym = "Версия внешнего отчета")]
    [StringLength(32)]
    public string ВнешнийОтчетВерсия {get; set;}
    [Description1C8(Name = "КешСхемЗвит1САктуален", Comment = "", Synonym = "Кеш схем FREDO Звіт актуален")]
    public bool КешСхемЗвит1САктуален {get; set;}
    #endregion реквізити
    }
}

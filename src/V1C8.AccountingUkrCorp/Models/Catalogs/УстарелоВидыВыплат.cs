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
    [Table("UstareloVydyVyplat")]
    [Description1C8(Name = "УстарелоВидыВыплат", Comment = "", Synonym = "ѳ(устарело) Виды выплат")]
    public class УстарелоВидыВыплат
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
    [Description1C8(Name = "УДАЛИТЬВидРасчета", Comment = "", Synonym = "(не используется) Вид расчета")]
    public ПланВидовРасчета.УстарелоНачисления УДАЛИТЬВидРасчета {get; set;}
    [Description1C8(Name = "РасчетОтОбратного", Comment = "", Synonym = "Расчет от обратного")]
    public bool РасчетОтОбратного {get; set;}
    [Description1C8(Name = "РасчитыватьВзносы", Comment = "", Synonym = "Расчитывать взносы")]
    public bool РасчитыватьВзносы {get; set;}
    [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
    public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    #endregion реквізити
    }
}

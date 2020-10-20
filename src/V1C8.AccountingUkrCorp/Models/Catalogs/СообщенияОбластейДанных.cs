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
    [Table("SoobshchenyiaOblasteiDannykh")]
    [Description1C8(Name = "СообщенияОбластейДанных", Comment = "", Synonym = "Сообщения областей данных")]
    public class СообщенияОбластейДанных:EnumItem
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
    [Description1C8(Name = "ТелоСообщения", Comment = "", Synonym = "Тело сообщения")]
    public DBNull ТелоСообщения {get; set;}
    [Description1C8(Name = "Отправитель", Comment = "", Synonym = "Отправитель")]
    public DBNull Отправитель {get; set;}
    [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
    public DBNull Получатель {get; set;}
    [Description1C8(Name = "Заблокировано", Comment = "", Synonym = "Заблокировано")]
    public bool Заблокировано {get; set;}
    [Description1C8(Name = "КоличествоПопытокОбработкиСообщения", Comment = "", Synonym = "Количество попыток обработки сообщения")]
    public DBNull КоличествоПопытокОбработкиСообщения {get; set;}
    [Description1C8(Name = "ПодробноеПредставлениеОшибки", Comment = "", Synonym = "Подробное представление ошибки")]
    public string ПодробноеПредставлениеОшибки {get; set;}
    [Description1C8(Name = "ЭтоБыстроеСообщение", Comment = "Признак того, что сообщение требуется доставить и обработать быстро, вне порядка общей очереди сообщений.", Synonym = "Это быстрое сообщение")]
    public bool ЭтоБыстроеСообщение {get; set;}
    #endregion реквізити
    }
}

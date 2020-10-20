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
    [Table("VydyOtpuskov")]
    [Description1C8(Name = "ВидыОтпусков", Comment = "", Synonym = "Виды отпусков")]
    public class ВидыОтпусков:CatalogItem
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
    [Description1C8(Name = "ОтпускЯвляетсяЕжегодным", Comment = "", Synonym = "Отпуск является ежегодным")]
    public bool ОтпускЯвляетсяЕжегодным {get; set;}
    [Description1C8(Name = "СпособРасчетаОтпуска", Comment = "", Synonym = "Способ расчета отпуска")]
    public Enums.СпособыРасчетаОтпуска СпособРасчетаОтпуска {get; set;}
    [Description1C8(Name = "ПредоставлятьОтпускВсемСотрудникам", Comment = "", Synonym = "Предоставлять отпуск всем сотрудникам")]
    public bool ПредоставлятьОтпускВсемСотрудникам {get; set;}
    [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
    // Format 2.0
    public long КоличествоДнейВГод {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование для печати")]
    [StringLength(250)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ОтпускБезОплаты", Comment = "", Synonym = "Отпуск без оплаты")]
    public bool ОтпускБезОплаты {get; set;}
    [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "Удалить идентификатор объекта")]
    [StringLength(256)]
    public string УдалитьИдентификаторОбъекта {get; set;}
    [Description1C8(Name = "Недействителен", Comment = "", Synonym = "Отпуск больше не используется")]
    public bool Недействителен {get; set;}
    [Description1C8(Name = "ОсновнойОтпуск", Comment = "", Synonym = "Основной отпуск")]
    public bool ОсновнойОтпуск {get; set;}
    [Description1C8(Name = "ХарактерЗависимостиДнейОтпуска", Comment = "", Synonym = "зависит от стажа")]
    public Enums.ХарактерЗависимостиКоличестваДнейОтпуска ХарактерЗависимостиДнейОтпуска {get; set;}
    [Description1C8(Name = "ВидСтажа", Comment = "", Synonym = "Вид стажа")]
    public Catalogs.ВидыСтажа ВидСтажа {get; set;}
    #endregion реквізити
    }
}

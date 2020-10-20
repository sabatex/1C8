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
    [Table("PokazatelyRaschetaZarplaty")]
    [Description1C8(Name = "ПоказателиРасчетаЗарплаты", Comment = "", Synonym = "Показатели расчета зарплаты")]
    public class ПоказателиРасчетаЗарплаты:EnumItem
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
    [Description1C8(Name = "КраткоеНаименование", Comment = "", Synonym = "Краткое наименование")]
    [StringLength(20)]
    public string КраткоеНаименование {get; set;}
    [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
    [StringLength(100)]
    public string Идентификатор {get; set;}
    [Description1C8(Name = "НазначениеПоказателя", Comment = "", Synonym = "Назначение показателя")]
    public DBNull НазначениеПоказателя {get; set;}
    [Description1C8(Name = "ТипПоказателя", Comment = "", Synonym = "Тип показателя")]
    public DBNull ТипПоказателя {get; set;}
    [Description1C8(Name = "ЗначениеРассчитываетсяАвтоматически", Comment = "Признак определяет возможность ввода значения пользователем", Synonym = "Значение рассчитывается автоматически")]
    public bool ЗначениеРассчитываетсяАвтоматически {get; set;}
    [Description1C8(Name = "СпособПримененияЗначений", Comment = "", Synonym = "Способ применения значений")]
    public DBNull СпособПримененияЗначений {get; set;}
    [Description1C8(Name = "СпособВводаЗначений", Comment = "", Synonym = "Способ ввода значений")]
    public DBNull СпособВводаЗначений {get; set;}
    [Description1C8(Name = "ВидСтажа", Comment = "", Synonym = "Вид стажа")]
    public DBNull ВидСтажа {get; set;}
    [Description1C8(Name = "Точность", Comment = "", Synonym = "Точность")]
    // Format 1.0
    public long Точность {get; set;}
    [Description1C8(Name = "ОтображатьВДокументахНачисления", Comment = "", Synonym = "Отображать в документах начисления зарплаты")]
    public bool ОтображатьВДокументахНачисления {get; set;}
    [Description1C8(Name = "ИдентификаторСлужебный", Comment = "", Synonym = "Идентификатор служебный")]
    [StringLength(100)]
    public string ИдентификаторСлужебный {get; set;}
    [Description1C8(Name = "БазовыйПоказатель", Comment = "", Synonym = "Базовый показатель")]
    public DBNull БазовыйПоказатель {get; set;}
    [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
    public DBNull ВидТарифнойСтавки {get; set;}
    [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "(не используется) Идентификатор объекта")]
    [StringLength(256)]
    public string УдалитьИдентификаторОбъекта {get; set;}
    [Description1C8(Name = "НеИспользуется", Comment = "", Synonym = "Показатель больше не используется")]
    public bool НеИспользуется {get; set;}
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    // Format 5.0
    public long РеквизитДопУпорядочивания {get; set;}
    #endregion реквізити
    }
}

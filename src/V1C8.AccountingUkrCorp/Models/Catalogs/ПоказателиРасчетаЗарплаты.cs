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
    public class ПоказателиРасчетаЗарплаты:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "КраткоеНаименование", Comment = "", Synonym = "Краткое наименование")]
        [StringLength(20)]
        public string КраткоеНаименование {get; set;}
        [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
        [StringLength(100)]
        public string Идентификатор {get; set;}
        [Description1C8(Name = "НазначениеПоказателя", Comment = "", Synonym = "Назначение показателя")]
        public Enums.НазначенияПоказателейРасчетаЗарплаты НазначениеПоказателя {get; set;}
        [Description1C8(Name = "ТипПоказателя", Comment = "", Synonym = "Тип показателя")]
        public Enums.ТипыПоказателейРасчетаЗарплаты ТипПоказателя {get; set;}
        [Description1C8(Name = "ЗначениеРассчитываетсяАвтоматически", Comment = "Признак определяет возможность ввода значения пользователем", Synonym = "Значение рассчитывается автоматически")]
        public bool ЗначениеРассчитываетсяАвтоматически {get; set;}
        [Description1C8(Name = "СпособПримененияЗначений", Comment = "", Synonym = "Способ применения значений")]
        public Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты СпособПримененияЗначений {get; set;}
        [Description1C8(Name = "СпособВводаЗначений", Comment = "", Synonym = "Способ ввода значений")]
        public Enums.СпособыВводаЗначенийПоказателейРасчетаЗарплаты СпособВводаЗначений {get; set;}
        [Description1C8(Name = "ВидСтажа", Comment = "", Synonym = "Вид стажа")]
        public Catalogs.ВидыСтажа ВидСтажа {get; set;}
        [Description1C8(Name = "Точность", Comment = "", Synonym = "Точность")]
        // Format 1.0
        public long Точность {get; set;}
        [Description1C8(Name = "ОтображатьВДокументахНачисления", Comment = "", Synonym = "Отображать в документах начисления зарплаты")]
        public bool ОтображатьВДокументахНачисления {get; set;}
        [Description1C8(Name = "ИдентификаторСлужебный", Comment = "", Synonym = "Идентификатор служебный")]
        [StringLength(100)]
        public string ИдентификаторСлужебный {get; set;}
        [Description1C8(Name = "БазовыйПоказатель", Comment = "", Synonym = "Базовый показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты БазовыйПоказатель {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "(не используется) Идентификатор объекта")]
        [StringLength(256)]
        public string УдалитьИдентификаторОбъекта {get; set;}
        [Description1C8(Name = "НеИспользуется", Comment = "", Synonym = "Показатель больше не используется")]
        public bool НеИспользуется {get; set;}
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ШкалаОценкиСтажа", Comment = "", Synonym = "Шкала оценки стажа")]
        public List<ПоказателиРасчетаЗарплаты_ШкалаОценкиСтажа> ПоказателиРасчетаЗарплатыШкалаОценкиСтажа {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШкалаОценкиСтажа", Comment = "", Synonym = "Шкала оценки стажа")]
    [Table("PokazatelyRaschetaZarplaty_ShkalaOtsenkyStazha")]
    public class ПоказателиРасчетаЗарплаты_ШкалаОценкиСтажа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВерхняяГраницаИнтервалаСтажа", Comment = "", Synonym = "Стаж, мес.")]
        // Format 15.3
        public decimal ВерхняяГраницаИнтервалаСтажа {get; set;}
        [Description1C8(Name = "ЗначениеПоказателя", Comment = "", Synonym = "Значение показателя")]
        // Format 15.3
        public decimal ЗначениеПоказателя {get; set;}
    }
}

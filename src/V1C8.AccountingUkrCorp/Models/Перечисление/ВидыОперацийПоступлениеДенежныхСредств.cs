using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПоступлениеДенежныхСредств", Comment = "(Общ)", Synonym = "Виды операций поступления денежных средств")]
    public enum ВидыОперацийПоступлениеДенежныхСредств
    {
        [Description1C8(Name = "ОплатаПокупателя", Comment = "(Общ)", Synonym = "Оплата от покупателя")]
        ОплатаПокупателя,
        [Description1C8(Name = "ВозвратДенежныхСредствПоставщиком", Comment = "(Общ)", Synonym = "Возврат от поставщика")]
        ВозвратДенежныхСредствПоставщиком,
        [Description1C8(Name = "РасчетыПоКредитамИЗаймам", Comment = "", Synonym = "Расчеты по кредитам и займам")]
        РасчетыПоКредитамИЗаймам,
        [Description1C8(Name = "ПрочиеРасчетыСКонтрагентами", Comment = "", Synonym = "Прочие расчеты с контрагентами")]
        ПрочиеРасчетыСКонтрагентами,
        [Description1C8(Name = "ИнкассацияДенежныхСредств", Comment = "", Synonym = "Инкассация")]
        ИнкассацияДенежныхСредств,
        [Description1C8(Name = "ПокупкаПродажаВалюты", Comment = "", Synonym = "Покупка/продажа валюты")]
        ПокупкаПродажаВалюты,
        [Description1C8(Name = "ПрочееПоступлениеБезналичныхДенежныхСредств", Comment = "", Synonym = "Прочее поступление")]
        ПрочееПоступлениеБезналичныхДенежныхСредств,
        [Description1C8(Name = "ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам", Comment = "", Synonym = "Поступления от продаж по платежным картам и банковским кредитам")]
        ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам,
        [Description1C8(Name = "ПоступлениеСредствОтФСС", Comment = "", Synonym = "Поступление средств от ФСС")]
        ПоступлениеСредствОтФСС,
        [Description1C8(Name = "ВозвратДенежныхСредствПодотчетником", Comment = "(Общ)", Synonym = "Возврат от подотчетного лица")]
        ВозвратДенежныхСредствПодотчетником
    }
}

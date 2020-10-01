using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыМонитораРуководителя", Comment = "", Synonym = "Разделы монитора руководителя")]
    public enum РазделыМонитораРуководителя
    {
        [Description1C8(Name = "ОстаткиДенежныхСредств", Comment = "", Synonym = "Остатки денежных средств")]
        ОстаткиДенежныхСредств,
        [Description1C8(Name = "ДвижениеДенежныхСредств", Comment = "", Synonym = "Движение денежных средств")]
        ДвижениеДенежныхСредств,
        [Description1C8(Name = "ПродажиПоКонтрагентам", Comment = "", Synonym = "Продажи по контрагентам")]
        ПродажиПоКонтрагентам,
        [Description1C8(Name = "ПродажиПоНоменклатурнымГруппам", Comment = "", Synonym = "Продажи по номенклатурным группам")]
        ПродажиПоНоменклатурнымГруппам,
        [Description1C8(Name = "ЗадолженностьПокупателей", Comment = "", Synonym = "Задолженность покупателей")]
        ЗадолженностьПокупателей,
        [Description1C8(Name = "ПросроченнаяЗадолженностьПокупателей", Comment = "", Synonym = "Просроченная задолженность покупателей")]
        ПросроченнаяЗадолженностьПокупателей,
        [Description1C8(Name = "ЗадолженностьПоставщикам", Comment = "", Synonym = "Задолженность поставщикам")]
        ЗадолженностьПоставщикам,
        [Description1C8(Name = "ПросроченнаяЗадолженностьПоставщикам", Comment = "", Synonym = "Просроченная задолженность поставщикам")]
        ПросроченнаяЗадолженностьПоставщикам
    }
}

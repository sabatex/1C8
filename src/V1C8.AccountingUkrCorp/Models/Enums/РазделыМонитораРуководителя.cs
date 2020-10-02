using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыМонитораРуководителя", Comment = "", Synonym = "Разделы монитора руководителя")]
    public class РазделыМонитораРуководителя:EnumItem
    {
        public static readonly РазделыМонитораРуководителя ОстаткиДенежныхСредств = new РазделыМонитораРуководителя{Name= "ОстаткиДенежныхСредств",Synonim="Остатки денежных средств",Comment=""};
        public static readonly РазделыМонитораРуководителя ДвижениеДенежныхСредств = new РазделыМонитораРуководителя{Name= "ДвижениеДенежныхСредств",Synonim="Движение денежных средств",Comment=""};
        public static readonly РазделыМонитораРуководителя ПродажиПоКонтрагентам = new РазделыМонитораРуководителя{Name= "ПродажиПоКонтрагентам",Synonim="Продажи по контрагентам",Comment=""};
        public static readonly РазделыМонитораРуководителя ПродажиПоНоменклатурнымГруппам = new РазделыМонитораРуководителя{Name= "ПродажиПоНоменклатурнымГруппам",Synonim="Продажи по номенклатурным группам",Comment=""};
        public static readonly РазделыМонитораРуководителя ЗадолженностьПокупателей = new РазделыМонитораРуководителя{Name= "ЗадолженностьПокупателей",Synonim="Задолженность покупателей",Comment=""};
        public static readonly РазделыМонитораРуководителя ПросроченнаяЗадолженностьПокупателей = new РазделыМонитораРуководителя{Name= "ПросроченнаяЗадолженностьПокупателей",Synonim="Просроченная задолженность покупателей",Comment=""};
        public static readonly РазделыМонитораРуководителя ЗадолженностьПоставщикам = new РазделыМонитораРуководителя{Name= "ЗадолженностьПоставщикам",Synonim="Задолженность поставщикам",Comment=""};
        public static readonly РазделыМонитораРуководителя ПросроченнаяЗадолженностьПоставщикам = new РазделыМонитораРуководителя{Name= "ПросроченнаяЗадолженностьПоставщикам",Synonim="Просроченная задолженность поставщикам",Comment=""};
    }
}

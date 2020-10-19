using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("RazdelyMonytoraRukovodytelia")]
    [Description1C8(Name = "РазделыМонитораРуководителя", Comment = "", Synonym = "Разделы монитора руководителя")]
    public class РазделыМонитораРуководителя:EnumItem
    {
        public static readonly РазделыМонитораРуководителя ОстаткиДенежныхСредств = new РазделыМонитораРуководителя{Name= "ОстаткиДенежныхСредств",Synonym="Остатки денежных средств",Comment=""};
        public static readonly РазделыМонитораРуководителя ДвижениеДенежныхСредств = new РазделыМонитораРуководителя{Name= "ДвижениеДенежныхСредств",Synonym="Движение денежных средств",Comment=""};
        public static readonly РазделыМонитораРуководителя ПродажиПоКонтрагентам = new РазделыМонитораРуководителя{Name= "ПродажиПоКонтрагентам",Synonym="Продажи по контрагентам",Comment=""};
        public static readonly РазделыМонитораРуководителя ПродажиПоНоменклатурнымГруппам = new РазделыМонитораРуководителя{Name= "ПродажиПоНоменклатурнымГруппам",Synonym="Продажи по номенклатурным группам",Comment=""};
        public static readonly РазделыМонитораРуководителя ЗадолженностьПокупателей = new РазделыМонитораРуководителя{Name= "ЗадолженностьПокупателей",Synonym="Задолженность покупателей",Comment=""};
        public static readonly РазделыМонитораРуководителя ПросроченнаяЗадолженностьПокупателей = new РазделыМонитораРуководителя{Name= "ПросроченнаяЗадолженностьПокупателей",Synonym="Просроченная задолженность покупателей",Comment=""};
        public static readonly РазделыМонитораРуководителя ЗадолженностьПоставщикам = new РазделыМонитораРуководителя{Name= "ЗадолженностьПоставщикам",Synonym="Задолженность поставщикам",Comment=""};
        public static readonly РазделыМонитораРуководителя ПросроченнаяЗадолженностьПоставщикам = new РазделыМонитораРуководителя{Name= "ПросроченнаяЗадолженностьПоставщикам",Synonym="Просроченная задолженность поставщикам",Comment=""};
    }
}

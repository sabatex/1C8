using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКонтрагентовВМонитореРуководителя", Comment = "", Synonym = "Виды контрагентов в мониторе руководителя")]
    public class ВидыКонтрагентовВМонитореРуководителя:EnumItem
    {
        public static readonly ВидыКонтрагентовВМонитореРуководителя Покупатели = new ВидыКонтрагентовВМонитореРуководителя{Name= "Покупатели",Synonim="Покупатели",Comment=""};
        public static readonly ВидыКонтрагентовВМонитореРуководителя Поставщики = new ВидыКонтрагентовВМонитореРуководителя{Name= "Поставщики",Synonim="Поставщики",Comment=""};
    }
}

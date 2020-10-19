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
    [Table("VydyKontrahentovVMonytoreRukovodytelia")]
    [Description1C8(Name = "ВидыКонтрагентовВМонитореРуководителя", Comment = "", Synonym = "Виды контрагентов в мониторе руководителя")]
    public class ВидыКонтрагентовВМонитореРуководителя:EnumItem
    {
        public static readonly ВидыКонтрагентовВМонитореРуководителя Покупатели = new ВидыКонтрагентовВМонитореРуководителя{Name= "Покупатели",Synonym="Покупатели",Comment=""};
        public static readonly ВидыКонтрагентовВМонитореРуководителя Поставщики = new ВидыКонтрагентовВМонитореРуководителя{Name= "Поставщики",Synonym="Поставщики",Comment=""};
    }
}

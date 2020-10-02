using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтавкиНДС", Comment = "(Общ)", Synonym = "Ставки НДС")]
    public class СтавкиНДС:EnumItem
    {
        public static readonly СтавкиНДС НДС20 = new СтавкиНДС{Name= "НДС20",Synonim="20%",Comment="(Общ) Ставка НДС 20%"};
        public static readonly СтавкиНДС НДС7 = new СтавкиНДС{Name= "НДС7",Synonim="7%",Comment=""};
        public static readonly СтавкиНДС НДС0 = new СтавкиНДС{Name= "НДС0",Synonim="0%",Comment="(Общ) Ставка НДС 0%"};
        public static readonly СтавкиНДС БезНДС = new СтавкиНДС{Name= "БезНДС",Synonim="Без НДС",Comment="(Общ)"};
        public static readonly СтавкиНДС НеНДС = new СтавкиНДС{Name= "НеНДС",Synonim="Не НДС",Comment=""};
    }
}

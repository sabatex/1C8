using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтавкиНДС", Comment = "(Общ)", Synonym = "Ставки НДС")]
    public class СтавкиНДС:EnumItem
    {
        public static readonly СтавкиНДС НДС20 = new СтавкиНДС{Name= "НДС20",Synonym="20%",Comment="(Общ) Ставка НДС 20%"};
        public static readonly СтавкиНДС НДС7 = new СтавкиНДС{Name= "НДС7",Synonym="7%",Comment=""};
        public static readonly СтавкиНДС НДС0 = new СтавкиНДС{Name= "НДС0",Synonym="0%",Comment="(Общ) Ставка НДС 0%"};
        public static readonly СтавкиНДС БезНДС = new СтавкиНДС{Name= "БезНДС",Synonym="Без НДС",Comment="(Общ)"};
        public static readonly СтавкиНДС НеНДС = new СтавкиНДС{Name= "НеНДС",Synonym="Не НДС",Comment=""};
    }
}

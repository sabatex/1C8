using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыУдержанияНДФЛ", Comment = "", Synonym = "Варианты удержания НДФЛ")]
    public class ВариантыУдержанияНДФЛ:EnumItem
    {
        public static readonly ВариантыУдержанияНДФЛ Удержано = new ВариантыУдержанияНДФЛ{Name= "Удержано",Synonim="Удержано",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ПереданоНаВзысканиеВНалоговыйОрган = new ВариантыУдержанияНДФЛ{Name= "ПереданоНаВзысканиеВНалоговыйОрган",Synonim="Передано на взыскание в налоговый орган",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ВозвращеноНалоговымАгентом = new ВариантыУдержанияНДФЛ{Name= "ВозвращеноНалоговымАгентом",Synonim="Возвращено налоговым агентом",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ЗачетАвансовыхПлатежей = new ВариантыУдержанияНДФЛ{Name= "ЗачетАвансовыхПлатежей",Synonim="Зачет авансовых платежей",Comment=""};
    }
}

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
    [Table("VaryantyUderzhanyiaNDFL")]
    [Description1C8(Name = "ВариантыУдержанияНДФЛ", Comment = "", Synonym = "Варианты удержания НДФЛ")]
    public class ВариантыУдержанияНДФЛ:EnumItem
    {
        public static readonly ВариантыУдержанияНДФЛ Удержано = new ВариантыУдержанияНДФЛ{Name= "Удержано",Synonym="Удержано",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ПереданоНаВзысканиеВНалоговыйОрган = new ВариантыУдержанияНДФЛ{Name= "ПереданоНаВзысканиеВНалоговыйОрган",Synonym="Передано на взыскание в налоговый орган",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ВозвращеноНалоговымАгентом = new ВариантыУдержанияНДФЛ{Name= "ВозвращеноНалоговымАгентом",Synonym="Возвращено налоговым агентом",Comment=""};
        public static readonly ВариантыУдержанияНДФЛ ЗачетАвансовыхПлатежей = new ВариантыУдержанияНДФЛ{Name= "ЗачетАвансовыхПлатежей",Synonym="Зачет авансовых платежей",Comment=""};
    }
}

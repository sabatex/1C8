using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыУдержанияНДФЛ", Comment = "", Synonym = "Варианты удержания НДФЛ")]
    public enum ВариантыУдержанияНДФЛ
    {
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        Удержано,
        [Description1C8(Name = "ПереданоНаВзысканиеВНалоговыйОрган", Comment = "", Synonym = "Передано на взыскание в налоговый орган")]
        ПереданоНаВзысканиеВНалоговыйОрган,
        [Description1C8(Name = "ВозвращеноНалоговымАгентом", Comment = "", Synonym = "Возвращено налоговым агентом")]
        ВозвращеноНалоговымАгентом,
        [Description1C8(Name = "ЗачетАвансовыхПлатежей", Comment = "", Synonym = "Зачет авансовых платежей")]
        ЗачетАвансовыхПлатежей
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСтавокНДФЛ", Comment = "(Регл)", Synonym = "Виды ставок НДФЛ")]
    public enum ВидыСтавокНДФЛ
    {
        [Description1C8(Name = "Уменьшенная", Comment = "5%", Synonym = "Уменьшенная")]
        Уменьшенная,
        [Description1C8(Name = "Основная", Comment = "13% (15%)", Synonym = "Основная")]
        Основная,
        [Description1C8(Name = "Двойная", Comment = "26% (30%)", Synonym = "Двойная")]
        Двойная,
        [Description1C8(Name = "НеОблагается", Comment = "", Synonym = "Не облагается")]
        НеОблагается,
        [Description1C8(Name = "СтавкаШахтеров", Comment = "10%", Synonym = "Ставка шахтеров")]
        СтавкаШахтеров,
        [Description1C8(Name = "Увеличенная", Comment = "17%", Synonym = "Увеличенная")]
        Увеличенная,
        [Description1C8(Name = "ВоенныйСбор", Comment = "", Synonym = "Военный сбор")]
        ВоенныйСбор
    }
}

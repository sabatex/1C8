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
    [Table("VydyStavokNDFL")]
    [Description1C8(Name = "ВидыСтавокНДФЛ", Comment = "(Регл)", Synonym = "Виды ставок НДФЛ")]
    public class ВидыСтавокНДФЛ:EnumItem
    {
        public static readonly ВидыСтавокНДФЛ Уменьшенная = new ВидыСтавокНДФЛ{Name= "Уменьшенная",Synonym="Уменьшенная",Comment="5%"};
        public static readonly ВидыСтавокНДФЛ Основная = new ВидыСтавокНДФЛ{Name= "Основная",Synonym="Основная",Comment="13% (15%)"};
        public static readonly ВидыСтавокНДФЛ Двойная = new ВидыСтавокНДФЛ{Name= "Двойная",Synonym="Двойная",Comment="26% (30%)"};
        public static readonly ВидыСтавокНДФЛ НеОблагается = new ВидыСтавокНДФЛ{Name= "НеОблагается",Synonym="Не облагается",Comment=""};
        public static readonly ВидыСтавокНДФЛ СтавкаШахтеров = new ВидыСтавокНДФЛ{Name= "СтавкаШахтеров",Synonym="Ставка шахтеров",Comment="10%"};
        public static readonly ВидыСтавокНДФЛ Увеличенная = new ВидыСтавокНДФЛ{Name= "Увеличенная",Synonym="Увеличенная",Comment="17%"};
        public static readonly ВидыСтавокНДФЛ ВоенныйСбор = new ВидыСтавокНДФЛ{Name= "ВоенныйСбор",Synonym="Военный сбор",Comment=""};
    }
}

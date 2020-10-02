using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСтавокНДФЛ", Comment = "(Регл)", Synonym = "Виды ставок НДФЛ")]
    public class ВидыСтавокНДФЛ:EnumItem
    {
        public static readonly ВидыСтавокНДФЛ Уменьшенная = new ВидыСтавокНДФЛ{Name= "Уменьшенная",Synonim="Уменьшенная",Comment="5%"};
        public static readonly ВидыСтавокНДФЛ Основная = new ВидыСтавокНДФЛ{Name= "Основная",Synonim="Основная",Comment="13% (15%)"};
        public static readonly ВидыСтавокНДФЛ Двойная = new ВидыСтавокНДФЛ{Name= "Двойная",Synonim="Двойная",Comment="26% (30%)"};
        public static readonly ВидыСтавокНДФЛ НеОблагается = new ВидыСтавокНДФЛ{Name= "НеОблагается",Synonim="Не облагается",Comment=""};
        public static readonly ВидыСтавокНДФЛ СтавкаШахтеров = new ВидыСтавокНДФЛ{Name= "СтавкаШахтеров",Synonim="Ставка шахтеров",Comment="10%"};
        public static readonly ВидыСтавокНДФЛ Увеличенная = new ВидыСтавокНДФЛ{Name= "Увеличенная",Synonim="Увеличенная",Comment="17%"};
        public static readonly ВидыСтавокНДФЛ ВоенныйСбор = new ВидыСтавокНДФЛ{Name= "ВоенныйСбор",Synonim="Военный сбор",Comment=""};
    }
}

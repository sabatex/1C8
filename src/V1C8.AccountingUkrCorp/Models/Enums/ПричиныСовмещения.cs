using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныСовмещения", Comment = "", Synonym = "Причины совмещения")]
    public class ПричиныСовмещения:EnumItem
    {
        public static readonly ПричиныСовмещения СовмещениеПрофессийДолжностей = new ПричиныСовмещения{Name= "СовмещениеПрофессийДолжностей",Synonim="Совмещение профессий (должностей)",Comment=""};
        public static readonly ПричиныСовмещения УвеличениеОбъемаРабот = new ПричиныСовмещения{Name= "УвеличениеОбъемаРабот",Synonim="Увеличение объема работ",Comment=""};
        public static readonly ПричиныСовмещения ИсполнениеОбязанностей = new ПричиныСовмещения{Name= "ИсполнениеОбязанностей",Synonim="Исполнение обязанностей",Comment=""};
    }
}

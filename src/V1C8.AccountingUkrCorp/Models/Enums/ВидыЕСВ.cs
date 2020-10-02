using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЕСВ", Comment = "", Synonym = "Виды ЕСВ")]
    public class ВидыЕСВ:EnumItem
    {
        public static readonly ВидыЕСВ ОсновнаяЗарплата = new ВидыЕСВ{Name= "ОсновнаяЗарплата",Synonim="Основная зарплата",Comment=""};
        public static readonly ВидыЕСВ ПоДоговорамГПХ = new ВидыЕСВ{Name= "ПоДоговорамГПХ",Synonim="По договорам ГПХ",Comment=""};
        public static readonly ВидыЕСВ Больничные = new ВидыЕСВ{Name= "Больничные",Synonim="Больничные",Comment=""};
        public static readonly ВидыЕСВ Декретные = new ВидыЕСВ{Name= "Декретные",Synonim="Декретные",Comment=""};
        public static readonly ВидыЕСВ НачисленияМобилизованным = new ВидыЕСВ{Name= "НачисленияМобилизованным",Synonim="Начисления мобилизованным",Comment=""};
        public static readonly ВидыЕСВ НеУчитывается = new ВидыЕСВ{Name= "НеУчитывается",Synonim="Не учитывается",Comment=""};
    }
}

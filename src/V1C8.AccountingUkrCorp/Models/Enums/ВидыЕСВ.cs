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
    [Table("VydyESV")]
    [Description1C8(Name = "ВидыЕСВ", Comment = "", Synonym = "Виды ЕСВ")]
    public class ВидыЕСВ:EnumItem
    {
        public static readonly ВидыЕСВ ОсновнаяЗарплата = new ВидыЕСВ{Name= "ОсновнаяЗарплата",Synonym="Основная зарплата",Comment=""};
        public static readonly ВидыЕСВ ПоДоговорамГПХ = new ВидыЕСВ{Name= "ПоДоговорамГПХ",Synonym="По договорам ГПХ",Comment=""};
        public static readonly ВидыЕСВ Больничные = new ВидыЕСВ{Name= "Больничные",Synonym="Больничные",Comment=""};
        public static readonly ВидыЕСВ Декретные = new ВидыЕСВ{Name= "Декретные",Synonym="Декретные",Comment=""};
        public static readonly ВидыЕСВ НачисленияМобилизованным = new ВидыЕСВ{Name= "НачисленияМобилизованным",Synonym="Начисления мобилизованным",Comment=""};
        public static readonly ВидыЕСВ НеУчитывается = new ВидыЕСВ{Name= "НеУчитывается",Synonym="Не учитывается",Comment=""};
    }
}

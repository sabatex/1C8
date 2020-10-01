using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЕСВ", Comment = "", Synonym = "Виды ЕСВ")]
    public enum ВидыЕСВ
    {
        [Description1C8(Name = "ОсновнаяЗарплата", Comment = "", Synonym = "Основная зарплата")]
        ОсновнаяЗарплата,
        [Description1C8(Name = "ПоДоговорамГПХ", Comment = "", Synonym = "По договорам ГПХ")]
        ПоДоговорамГПХ,
        [Description1C8(Name = "Больничные", Comment = "", Synonym = "Больничные")]
        Больничные,
        [Description1C8(Name = "Декретные", Comment = "", Synonym = "Декретные")]
        Декретные,
        [Description1C8(Name = "НачисленияМобилизованным", Comment = "", Synonym = "Начисления мобилизованным")]
        НачисленияМобилизованным,
        [Description1C8(Name = "НеУчитывается", Comment = "", Synonym = "Не учитывается")]
        НеУчитывается
    }
}

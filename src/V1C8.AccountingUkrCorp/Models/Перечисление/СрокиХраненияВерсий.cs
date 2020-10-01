using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СрокиХраненияВерсий", Comment = "", Synonym = "Сроки хранения версий")]
    public enum СрокиХраненияВерсий
    {
        [Description1C8(Name = "ЗаПоследнююНеделю", Comment = "", Synonym = "За последнюю неделю")]
        ЗаПоследнююНеделю,
        [Description1C8(Name = "ЗаПоследнийМесяц", Comment = "", Synonym = "За последний месяц")]
        ЗаПоследнийМесяц,
        [Description1C8(Name = "ЗаПоследниеТриМесяца", Comment = "", Synonym = "За последние три месяца")]
        ЗаПоследниеТриМесяца,
        [Description1C8(Name = "ЗаПоследниеШестьМесяцев", Comment = "", Synonym = "За последние шесть месяцев")]
        ЗаПоследниеШестьМесяцев,
        [Description1C8(Name = "ЗаПоследнийГод", Comment = "", Synonym = "За последний год")]
        ЗаПоследнийГод,
        [Description1C8(Name = "Бессрочно", Comment = "", Synonym = "Бессрочно")]
        Бессрочно
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СрокиХраненияВерсий", Comment = "", Synonym = "Сроки хранения версий")]
    public class СрокиХраненияВерсий:EnumItem
    {
        public static readonly СрокиХраненияВерсий ЗаПоследнююНеделю = new СрокиХраненияВерсий{Name= "ЗаПоследнююНеделю",Synonym="За последнюю неделю",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследнийМесяц = new СрокиХраненияВерсий{Name= "ЗаПоследнийМесяц",Synonym="За последний месяц",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследниеТриМесяца = new СрокиХраненияВерсий{Name= "ЗаПоследниеТриМесяца",Synonym="За последние три месяца",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследниеШестьМесяцев = new СрокиХраненияВерсий{Name= "ЗаПоследниеШестьМесяцев",Synonym="За последние шесть месяцев",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследнийГод = new СрокиХраненияВерсий{Name= "ЗаПоследнийГод",Synonym="За последний год",Comment=""};
        public static readonly СрокиХраненияВерсий Бессрочно = new СрокиХраненияВерсий{Name= "Бессрочно",Synonym="Бессрочно",Comment=""};
    }
}

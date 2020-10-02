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
        public static readonly СрокиХраненияВерсий ЗаПоследнююНеделю = new СрокиХраненияВерсий{Name= "ЗаПоследнююНеделю",Synonim="За последнюю неделю",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследнийМесяц = new СрокиХраненияВерсий{Name= "ЗаПоследнийМесяц",Synonim="За последний месяц",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследниеТриМесяца = new СрокиХраненияВерсий{Name= "ЗаПоследниеТриМесяца",Synonim="За последние три месяца",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследниеШестьМесяцев = new СрокиХраненияВерсий{Name= "ЗаПоследниеШестьМесяцев",Synonim="За последние шесть месяцев",Comment=""};
        public static readonly СрокиХраненияВерсий ЗаПоследнийГод = new СрокиХраненияВерсий{Name= "ЗаПоследнийГод",Synonim="За последний год",Comment=""};
        public static readonly СрокиХраненияВерсий Бессрочно = new СрокиХраненияВерсий{Name= "Бессрочно",Synonim="Бессрочно",Comment=""};
    }
}

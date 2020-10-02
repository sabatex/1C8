using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыУстановкиКурсаВалюты", Comment = "", Synonym = "Способы установки курса валюты")]
    public class СпособыУстановкиКурсаВалюты:EnumItem
    {
        public static readonly СпособыУстановкиКурсаВалюты ЗагрузкаИзИнтернета = new СпособыУстановкиКурсаВалюты{Name= "ЗагрузкаИзИнтернета",Synonim="Загрузка из интернета",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты РучнойВвод = new СпособыУстановкиКурсаВалюты{Name= "РучнойВвод",Synonim="Ручной ввод",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты НаценкаНаКурсДругойВалюты = new СпособыУстановкиКурсаВалюты{Name= "НаценкаНаКурсДругойВалюты",Synonim="Наценка на курс другой валюты",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты РасчетПоФормуле = new СпособыУстановкиКурсаВалюты{Name= "РасчетПоФормуле",Synonim="Расчет по формуле",Comment=""};
    }
}

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
    [Table("SposobyUstanovkyKursaValiuty")]
    [Description1C8(Name = "СпособыУстановкиКурсаВалюты", Comment = "", Synonym = "Способы установки курса валюты")]
    public class СпособыУстановкиКурсаВалюты:EnumItem
    {
        public static readonly СпособыУстановкиКурсаВалюты ЗагрузкаИзИнтернета = new СпособыУстановкиКурсаВалюты{Name= "ЗагрузкаИзИнтернета",Synonym="Загрузка из интернета",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты РучнойВвод = new СпособыУстановкиКурсаВалюты{Name= "РучнойВвод",Synonym="Ручной ввод",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты НаценкаНаКурсДругойВалюты = new СпособыУстановкиКурсаВалюты{Name= "НаценкаНаКурсДругойВалюты",Synonym="Наценка на курс другой валюты",Comment=""};
        public static readonly СпособыУстановкиКурсаВалюты РасчетПоФормуле = new СпособыУстановкиКурсаВалюты{Name= "РасчетПоФормуле",Synonym="Расчет по формуле",Comment=""};
    }
}

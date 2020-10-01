using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыУстановкиКурсаВалюты", Comment = "", Synonym = "Способы установки курса валюты")]
    public enum СпособыУстановкиКурсаВалюты
    {
        [Description1C8(Name = "ЗагрузкаИзИнтернета", Comment = "", Synonym = "Загрузка из интернета")]
        ЗагрузкаИзИнтернета,
        [Description1C8(Name = "РучнойВвод", Comment = "", Synonym = "Ручной ввод")]
        РучнойВвод,
        [Description1C8(Name = "НаценкаНаКурсДругойВалюты", Comment = "", Synonym = "Наценка на курс другой валюты")]
        НаценкаНаКурсДругойВалюты,
        [Description1C8(Name = "РасчетПоФормуле", Comment = "", Synonym = "Расчет по формуле")]
        РасчетПоФормуле
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКорректировокНалоговогоКредита", Comment = "", Synonym = "Виды корректировок налогового кредита")]
    public enum ВидыКорректировокНалоговогоКредита
    {
        [Description1C8(Name = "ПотеряПраваНаНалоговыйКредит", Comment = "", Synonym = "Потеря права на налоговый кредит")]
        ПотеряПраваНаНалоговыйКредит,
        [Description1C8(Name = "ВосстановлениеПраваНаНалоговыйКредит", Comment = "", Synonym = "Восстановление права на налоговый кредит")]
        ВосстановлениеПраваНаНалоговыйКредит,
        [Description1C8(Name = "НетКорректировок", Comment = "", Synonym = "Нет корректировок")]
        НетКорректировок
    }
}

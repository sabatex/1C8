using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МетодыКорректировкиНалоговогоКредита", Comment = "(Регл)", Synonym = "Методы корректировки налогового кредита")]
    public enum МетодыКорректировкиНалоговогоКредита
    {
        [Description1C8(Name = "НаНалоговыйКредит", Comment = "", Synonym = "Начислить кредит")]
        НаНалоговыйКредит,
        [Description1C8(Name = "НаНалоговыеОбязательства", Comment = "", Synonym = "Начислить обязательства")]
        НаНалоговыеОбязательства,
        [Description1C8(Name = "НеКорректировать", Comment = "", Synonym = "Не корректировать")]
        НеКорректировать
    }
}

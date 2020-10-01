using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЗначениеРесурсаРегистровСостоянийСотрудника", Comment = "", Synonym = "Значение ресурса регистров состояний сотрудника")]
    public enum ЗначениеРесурсаРегистровСостоянийСотрудника
    {
        [Description1C8(Name = "НеУстановлено", Comment = "", Synonym = "Не установлено")]
        НеУстановлено,
        [Description1C8(Name = "Установлено", Comment = "", Synonym = "Установлено")]
        Установлено,
        [Description1C8(Name = "УстановленоЗначениеПоУмолчанию", Comment = "", Synonym = "Установлено значение по умолчанию")]
        УстановленоЗначениеПоУмолчанию
    }
}

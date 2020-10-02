using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЗначениеРесурсаРегистровСостоянийСотрудника", Comment = "", Synonym = "Значение ресурса регистров состояний сотрудника")]
    public class ЗначениеРесурсаРегистровСостоянийСотрудника:EnumItem
    {
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника НеУстановлено = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "НеУстановлено",Synonim="Не установлено",Comment=""};
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника Установлено = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "Установлено",Synonim="Установлено",Comment=""};
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника УстановленоЗначениеПоУмолчанию = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "УстановленоЗначениеПоУмолчанию",Synonim="Установлено значение по умолчанию",Comment=""};
    }
}

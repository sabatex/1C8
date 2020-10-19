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
    [Table("ZnachenyeResursaRehystrovSostoianyiSotrudnyka")]
    [Description1C8(Name = "ЗначениеРесурсаРегистровСостоянийСотрудника", Comment = "", Synonym = "Значение ресурса регистров состояний сотрудника")]
    public class ЗначениеРесурсаРегистровСостоянийСотрудника:EnumItem
    {
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника НеУстановлено = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "НеУстановлено",Synonym="Не установлено",Comment=""};
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника Установлено = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "Установлено",Synonym="Установлено",Comment=""};
        public static readonly ЗначениеРесурсаРегистровСостоянийСотрудника УстановленоЗначениеПоУмолчанию = new ЗначениеРесурсаРегистровСостоянийСотрудника{Name= "УстановленоЗначениеПоУмолчанию",Synonym="Установлено значение по умолчанию",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКорректировокНалоговогоКредита", Comment = "", Synonym = "Виды корректировок налогового кредита")]
    public class ВидыКорректировокНалоговогоКредита:EnumItem
    {
        public static readonly ВидыКорректировокНалоговогоКредита ПотеряПраваНаНалоговыйКредит = new ВидыКорректировокНалоговогоКредита{Name= "ПотеряПраваНаНалоговыйКредит",Synonim="Потеря права на налоговый кредит",Comment=""};
        public static readonly ВидыКорректировокНалоговогоКредита ВосстановлениеПраваНаНалоговыйКредит = new ВидыКорректировокНалоговогоКредита{Name= "ВосстановлениеПраваНаНалоговыйКредит",Synonim="Восстановление права на налоговый кредит",Comment=""};
        public static readonly ВидыКорректировокНалоговогоКредита НетКорректировок = new ВидыКорректировокНалоговогоКредита{Name= "НетКорректировок",Synonim="Нет корректировок",Comment=""};
    }
}

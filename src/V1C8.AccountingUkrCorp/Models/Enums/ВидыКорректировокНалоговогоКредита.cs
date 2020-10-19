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
    [Table("VydyKorrektyrovokNalohovohoKredyta")]
    [Description1C8(Name = "ВидыКорректировокНалоговогоКредита", Comment = "", Synonym = "Виды корректировок налогового кредита")]
    public class ВидыКорректировокНалоговогоКредита:EnumItem
    {
        public static readonly ВидыКорректировокНалоговогоКредита ПотеряПраваНаНалоговыйКредит = new ВидыКорректировокНалоговогоКредита{Name= "ПотеряПраваНаНалоговыйКредит",Synonym="Потеря права на налоговый кредит",Comment=""};
        public static readonly ВидыКорректировокНалоговогоКредита ВосстановлениеПраваНаНалоговыйКредит = new ВидыКорректировокНалоговогоКредита{Name= "ВосстановлениеПраваНаНалоговыйКредит",Synonym="Восстановление права на налоговый кредит",Comment=""};
        public static readonly ВидыКорректировокНалоговогоКредита НетКорректировок = new ВидыКорректировокНалоговогоКредита{Name= "НетКорректировок",Synonym="Нет корректировок",Comment=""};
    }
}

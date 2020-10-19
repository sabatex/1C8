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
    [Table("RazdelyUcheta")]
    [Description1C8(Name = "РазделыУчета", Comment = "", Synonym = "Разделы учета")]
    public class РазделыУчета:EnumItem
    {
        public static readonly РазделыУчета ОценкаМПЗ = new РазделыУчета{Name= "ОценкаМПЗ",Synonym="Оценка МПЗ при выбытии",Comment=""};
        public static readonly РазделыУчета РасчетыСКонтрагентами = new РазделыУчета{Name= "РасчетыСКонтрагентами",Synonym="Расчеты с контрагентами",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУчетаВремениДляСредней", Comment = "", Synonym = "Виды учета времени для средней")]
    public class ВидыУчетаВремениДляСредней:EnumItem
    {
        public static readonly ВидыУчетаВремениДляСредней ПоРабочимДням = new ВидыУчетаВремениДляСредней{Name= "ПоРабочимДням",Synonym="По рабочим дням",Comment=""};
        public static readonly ВидыУчетаВремениДляСредней ПоРабочимЧасам = new ВидыУчетаВремениДляСредней{Name= "ПоРабочимЧасам",Synonym="По рабочим часам",Comment=""};
    }
}

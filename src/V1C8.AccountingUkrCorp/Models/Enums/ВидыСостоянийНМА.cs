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
    [Table("VydySostoianyiNMA")]
    [Description1C8(Name = "ВидыСостоянийНМА", Comment = "(Регл)", Synonym = "Виды состояний НМА")]
    public class ВидыСостоянийНМА:EnumItem
    {
        public static readonly ВидыСостоянийНМА Поступил = new ВидыСостоянийНМА{Name= "Поступил",Synonym="Поступил",Comment=""};
        public static readonly ВидыСостоянийНМА ПринятКУчету = new ВидыСостоянийНМА{Name= "ПринятКУчету",Synonym="Принят к учету",Comment=""};
        public static readonly ВидыСостоянийНМА Списан = new ВидыСостоянийНМА{Name= "Списан",Synonym="Списан",Comment=""};
    }
}

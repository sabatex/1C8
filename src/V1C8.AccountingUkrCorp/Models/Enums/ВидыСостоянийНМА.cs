using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСостоянийНМА", Comment = "(Регл)", Synonym = "Виды состояний НМА")]
    public class ВидыСостоянийНМА:EnumItem
    {
        public static readonly ВидыСостоянийНМА Поступил = new ВидыСостоянийНМА{Name= "Поступил",Synonim="Поступил",Comment=""};
        public static readonly ВидыСостоянийНМА ПринятКУчету = new ВидыСостоянийНМА{Name= "ПринятКУчету",Synonim="Принят к учету",Comment=""};
        public static readonly ВидыСостоянийНМА Списан = new ВидыСостоянийНМА{Name= "Списан",Synonim="Списан",Comment=""};
    }
}

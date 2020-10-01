using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСостоянийНМА", Comment = "(Регл)", Synonym = "Виды состояний НМА")]
    public enum ВидыСостоянийНМА
    {
        [Description1C8(Name = "Поступил", Comment = "", Synonym = "Поступил")]
        Поступил,
        [Description1C8(Name = "ПринятКУчету", Comment = "", Synonym = "Принят к учету")]
        ПринятКУчету,
        [Description1C8(Name = "Списан", Comment = "", Synonym = "Списан")]
        Списан
    }
}

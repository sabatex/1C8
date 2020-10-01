using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыГруппУчетаНачисленийИУдержаний", Comment = "", Synonym = "Виды групп учета начислений и удержаний")]
    public enum ВидыГруппУчетаНачисленийИУдержаний
    {
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        Начисления,
        [Description1C8(Name = "ОсобыеНачисления", Comment = "", Synonym = "Особые начисления")]
        ОсобыеНачисления,
        [Description1C8(Name = "НалогиИВзносы", Comment = "", Synonym = "Налоги и взносы")]
        НалогиИВзносы,
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        Удержания,
        [Description1C8(Name = "Депоненты", Comment = "", Synonym = "Депоненты")]
        Депоненты
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыГруппУчетаНачисленийИУдержаний", Comment = "", Synonym = "Виды групп учета начислений и удержаний")]
    public class ВидыГруппУчетаНачисленийИУдержаний:EnumItem
    {
        public static readonly ВидыГруппУчетаНачисленийИУдержаний Начисления = new ВидыГруппУчетаНачисленийИУдержаний{Name= "Начисления",Synonim="Начисления",Comment=""};
        public static readonly ВидыГруппУчетаНачисленийИУдержаний ОсобыеНачисления = new ВидыГруппУчетаНачисленийИУдержаний{Name= "ОсобыеНачисления",Synonim="Особые начисления",Comment=""};
        public static readonly ВидыГруппУчетаНачисленийИУдержаний НалогиИВзносы = new ВидыГруппУчетаНачисленийИУдержаний{Name= "НалогиИВзносы",Synonim="Налоги и взносы",Comment=""};
        public static readonly ВидыГруппУчетаНачисленийИУдержаний Удержания = new ВидыГруппУчетаНачисленийИУдержаний{Name= "Удержания",Synonim="Удержания",Comment=""};
        public static readonly ВидыГруппУчетаНачисленийИУдержаний Депоненты = new ВидыГруппУчетаНачисленийИУдержаний{Name= "Депоненты",Synonim="Депоненты",Comment=""};
    }
}

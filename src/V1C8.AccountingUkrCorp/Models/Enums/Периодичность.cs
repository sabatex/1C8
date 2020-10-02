using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "Периодичность", Comment = "(Упр)", Synonym = "Периодичность")]
    public class Периодичность:EnumItem
    {
        public static readonly Периодичность День = new Периодичность{Name= "День",Synonim="День",Comment=""};
        public static readonly Периодичность Неделя = new Периодичность{Name= "Неделя",Synonim="Неделя",Comment=""};
        public static readonly Периодичность Месяц = new Периодичность{Name= "Месяц",Synonim="Месяц",Comment=""};
        public static readonly Периодичность Квартал = new Периодичность{Name= "Квартал",Synonim="Квартал",Comment=""};
        public static readonly Периодичность Год = new Периодичность{Name= "Год",Synonim="Год",Comment=""};
        public static readonly Периодичность Декада = new Периодичность{Name= "Декада",Synonim="Декада",Comment=""};
        public static readonly Периодичность Полугодие = new Периодичность{Name= "Полугодие",Synonim="Полугодие",Comment=""};
    }
}

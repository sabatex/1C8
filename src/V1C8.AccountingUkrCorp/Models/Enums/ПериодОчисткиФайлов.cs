using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодОчисткиФайлов", Comment = "", Synonym = "Период очистки файлов")]
    public class ПериодОчисткиФайлов:EnumItem
    {
        public static readonly ПериодОчисткиФайлов СтаршеМесяца = new ПериодОчисткиФайлов{Name= "СтаршеМесяца",Synonim="Старше месяца",Comment=""};
        public static readonly ПериодОчисткиФайлов СтаршеШестиМесяцев = new ПериодОчисткиФайлов{Name= "СтаршеШестиМесяцев",Synonim="Старше шести месяцев",Comment=""};
        public static readonly ПериодОчисткиФайлов СтаршеГода = new ПериодОчисткиФайлов{Name= "СтаршеГода",Synonim="Старше года",Comment=""};
        public static readonly ПериодОчисткиФайлов ПоПравилу = new ПериодОчисткиФайлов{Name= "ПоПравилу",Synonim="По правилу",Comment=""};
    }
}

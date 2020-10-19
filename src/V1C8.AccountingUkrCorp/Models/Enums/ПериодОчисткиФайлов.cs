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
    [Table("PeryodOchystkyFailov")]
    [Description1C8(Name = "ПериодОчисткиФайлов", Comment = "", Synonym = "Период очистки файлов")]
    public class ПериодОчисткиФайлов:EnumItem
    {
        public static readonly ПериодОчисткиФайлов СтаршеМесяца = new ПериодОчисткиФайлов{Name= "СтаршеМесяца",Synonym="Старше месяца",Comment=""};
        public static readonly ПериодОчисткиФайлов СтаршеШестиМесяцев = new ПериодОчисткиФайлов{Name= "СтаршеШестиМесяцев",Synonym="Старше шести месяцев",Comment=""};
        public static readonly ПериодОчисткиФайлов СтаршеГода = new ПериодОчисткиФайлов{Name= "СтаршеГода",Synonym="Старше года",Comment=""};
        public static readonly ПериодОчисткиФайлов ПоПравилу = new ПериодОчисткиФайлов{Name= "ПоПравилу",Synonym="По правилу",Comment=""};
    }
}

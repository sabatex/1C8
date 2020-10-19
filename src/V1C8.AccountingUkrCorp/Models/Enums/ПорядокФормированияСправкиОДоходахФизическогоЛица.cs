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
    [Table("PoriadokFormyrovanyiaSpravkyODokhodakhFyzycheskohoLytsa")]
    [Description1C8(Name = "ПорядокФормированияСправкиОДоходахФизическогоЛица", Comment = "", Synonym = "Порядок формирования справки о доходах физического лица")]
    public class ПорядокФормированияСправкиОДоходахФизическогоЛица:EnumItem
    {
        public static readonly ПорядокФормированияСправкиОДоходахФизическогоЛица Сводно = new ПорядокФормированияСправкиОДоходахФизическогоЛица{Name= "Сводно",Synonym="Сводно",Comment=""};
        public static readonly ПорядокФормированияСправкиОДоходахФизическогоЛица ВРазрезеКодовОКАТО = new ПорядокФормированияСправкиОДоходахФизическогоЛица{Name= "ВРазрезеКодовОКАТО",Synonym="В разрезе кодов ОКАТО/КПП и ставок налога",Comment=""};
    }
}

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
    [Table("VydyObektovDostupa")]
    [Description1C8(Name = "ВидыОбъектовДоступа", Comment = "", Synonym = "Виды объектов доступа")]
    public class ВидыОбъектовДоступа:EnumItem
    {
        public static readonly ВидыОбъектовДоступа Организации = new ВидыОбъектовДоступа{Name= "Организации",Synonym="Организации",Comment=""};
        public static readonly ВидыОбъектовДоступа ВнешниеОбработки = new ВидыОбъектовДоступа{Name= "ВнешниеОбработки",Synonym="Внешние обработки",Comment=""};
    }
}

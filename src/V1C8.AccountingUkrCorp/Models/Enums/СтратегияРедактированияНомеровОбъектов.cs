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
    [Table("StratehyiaRedaktyrovanyiaNomerovObektov")]
    [Description1C8(Name = "СтратегияРедактированияНомеровОбъектов", Comment = "", Synonym = "Стратегия редактирования номеров объектов")]
    public class СтратегияРедактированияНомеровОбъектов:EnumItem
    {
        public static readonly СтратегияРедактированияНомеровОбъектов НеДоступно = new СтратегияРедактированияНомеровОбъектов{Name= "НеДоступно",Synonym="Недоступно",Comment=""};
        public static readonly СтратегияРедактированияНомеровОбъектов Доступно = new СтратегияРедактированияНомеровОбъектов{Name= "Доступно",Synonym="Доступно",Comment=""};
    }
}

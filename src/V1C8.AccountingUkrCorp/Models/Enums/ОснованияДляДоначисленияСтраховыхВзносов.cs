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
    [Table("OsnovanyiaDliaDonachyslenyiaStrakhovykhVznosov")]
    [Description1C8(Name = "ОснованияДляДоначисленияСтраховыхВзносов", Comment = "", Synonym = "Основания для доначисления страховых взносов")]
    public class ОснованияДляДоначисленияСтраховыхВзносов:EnumItem
    {
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов КамеральнаяПроверка = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "КамеральнаяПроверка",Synonym="Проверка фискальными органами",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов ВыезднаяПроверка = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "ВыезднаяПроверка",Synonym="ѳ(не украинский) Выездная проверка",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов ДляИсправленияОшибок = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "ДляИсправленияОшибок",Synonym="Самостоятельное исправление",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов КорректировкаНеПризнаннаяОшибкой = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "КорректировкаНеПризнаннаяОшибкой",Synonym="ѳ(не украинский) Корректировка не признанная ошибкой",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОснованияДляДоначисленияСтраховыхВзносов", Comment = "", Synonym = "Основания для доначисления страховых взносов")]
    public class ОснованияДляДоначисленияСтраховыхВзносов:EnumItem
    {
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов КамеральнаяПроверка = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "КамеральнаяПроверка",Synonim="Проверка фискальными органами",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов ВыезднаяПроверка = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "ВыезднаяПроверка",Synonim="ѳ(не украинский) Выездная проверка",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов ДляИсправленияОшибок = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "ДляИсправленияОшибок",Synonim="Самостоятельное исправление",Comment=""};
        public static readonly ОснованияДляДоначисленияСтраховыхВзносов КорректировкаНеПризнаннаяОшибкой = new ОснованияДляДоначисленияСтраховыхВзносов{Name= "КорректировкаНеПризнаннаяОшибкой",Synonim="ѳ(не украинский) Корректировка не признанная ошибкой",Comment=""};
    }
}

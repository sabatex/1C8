using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОснованияДляДоначисленияСтраховыхВзносов", Comment = "", Synonym = "Основания для доначисления страховых взносов")]
    public enum ОснованияДляДоначисленияСтраховыхВзносов
    {
        [Description1C8(Name = "КамеральнаяПроверка", Comment = "", Synonym = "Проверка фискальными органами")]
        КамеральнаяПроверка,
        [Description1C8(Name = "ВыезднаяПроверка", Comment = "", Synonym = "ѳ(не украинский) Выездная проверка")]
        ВыезднаяПроверка,
        [Description1C8(Name = "ДляИсправленияОшибок", Comment = "", Synonym = "Самостоятельное исправление")]
        ДляИсправленияОшибок,
        [Description1C8(Name = "КорректировкаНеПризнаннаяОшибкой", Comment = "", Synonym = "ѳ(не украинский) Корректировка не признанная ошибкой")]
        КорректировкаНеПризнаннаяОшибкой
    }
}

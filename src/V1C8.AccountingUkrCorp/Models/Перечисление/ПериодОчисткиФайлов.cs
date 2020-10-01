using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодОчисткиФайлов", Comment = "", Synonym = "Период очистки файлов")]
    public enum ПериодОчисткиФайлов
    {
        [Description1C8(Name = "СтаршеМесяца", Comment = "", Synonym = "Старше месяца")]
        СтаршеМесяца,
        [Description1C8(Name = "СтаршеШестиМесяцев", Comment = "", Synonym = "Старше шести месяцев")]
        СтаршеШестиМесяцев,
        [Description1C8(Name = "СтаршеГода", Comment = "", Synonym = "Старше года")]
        СтаршеГода,
        [Description1C8(Name = "ПоПравилу", Comment = "", Synonym = "По правилу")]
        ПоПравилу
    }
}

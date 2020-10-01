using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФормыОбучения", Comment = "", Synonym = "Формы обучения")]
    public enum ФормыОбучения
    {
        [Description1C8(Name = "Очная", Comment = "", Synonym = "Очная")]
        Очная,
        [Description1C8(Name = "Заочная", Comment = "", Synonym = "Заочная")]
        Заочная,
        [Description1C8(Name = "Вечерняя", Comment = "", Synonym = "Вечерняя")]
        Вечерняя,
        [Description1C8(Name = "Экстернат", Comment = "", Synonym = "Экстернат")]
        Экстернат,
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        Прочее
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияЗапросовНаИспользованиеВнешнихРесурсов", Comment = "", Synonym = "Состояния запросов на использование внешних ресурсов")]
    public enum СостоянияЗапросовНаИспользованиеВнешнихРесурсов
    {
        [Description1C8(Name = "Новый", Comment = "", Synonym = "Новый")]
        Новый,
        [Description1C8(Name = "Применен", Comment = "", Synonym = "Применен")]
        Применен,
        [Description1C8(Name = "Проверен", Comment = "", Synonym = "Проверен")]
        Проверен
    }
}

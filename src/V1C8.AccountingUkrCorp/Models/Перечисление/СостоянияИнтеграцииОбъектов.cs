using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияИнтеграцииОбъектов", Comment = "", Synonym = "Состояния интеграции объектов")]
    public enum СостоянияИнтеграцииОбъектов
    {
        [Description1C8(Name = "Ожидание", Comment = "", Synonym = "Ожидание")]
        Ожидание,
        [Description1C8(Name = "Интегрирован", Comment = "", Synonym = "Интегрирован")]
        Интегрирован,
        [Description1C8(Name = "Ошибка", Comment = "", Synonym = "Ошибка")]
        Ошибка
    }
}

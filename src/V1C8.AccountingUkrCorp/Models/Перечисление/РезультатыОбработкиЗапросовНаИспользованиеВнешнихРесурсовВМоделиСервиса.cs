using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса", Comment = "", Synonym = "Результаты обработки запросов на использование внешних ресурсов в модели сервиса")]
    public enum РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса
    {
        [Description1C8(Name = "ЗапросОдобрен", Comment = "", Synonym = "Запрос одобрен")]
        ЗапросОдобрен,
        [Description1C8(Name = "ЗапросОтклонен", Comment = "", Synonym = "Запрос отклонен")]
        ЗапросОтклонен
    }
}

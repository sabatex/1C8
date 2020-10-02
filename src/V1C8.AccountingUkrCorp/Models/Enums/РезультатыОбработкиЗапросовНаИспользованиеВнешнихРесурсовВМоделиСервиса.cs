using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса", Comment = "", Synonym = "Результаты обработки запросов на использование внешних ресурсов в модели сервиса")]
    public class РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса:EnumItem
    {
        public static readonly РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса ЗапросОдобрен = new РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса{Name= "ЗапросОдобрен",Synonym="Запрос одобрен",Comment=""};
        public static readonly РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса ЗапросОтклонен = new РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса{Name= "ЗапросОтклонен",Synonym="Запрос отклонен",Comment=""};
    }
}

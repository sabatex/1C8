using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДеятельностиДляДДС", Comment = "Виды деятельности для отчета ДДС", Synonym = "Виды деятельности для отчета ДДС")]
    public enum ВидыДеятельностиДляДДС
    {
        [Description1C8(Name = "Операционная", Comment = "", Synonym = "Операционная")]
        Операционная,
        [Description1C8(Name = "Инвестиционная", Comment = "", Synonym = "Инвестиционная")]
        Инвестиционная,
        [Description1C8(Name = "Финансовая", Comment = "", Synonym = "Финансовая")]
        Финансовая
    }
}

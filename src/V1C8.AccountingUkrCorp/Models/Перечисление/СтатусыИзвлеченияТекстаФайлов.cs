using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыИзвлеченияТекстаФайлов", Comment = "", Synonym = "Статусы извлечения текста файлов")]
    public enum СтатусыИзвлеченияТекстаФайлов
    {
        [Description1C8(Name = "НеИзвлечен", Comment = "", Synonym = "Не извлечен")]
        НеИзвлечен,
        [Description1C8(Name = "Извлечен", Comment = "", Synonym = "Извлечен")]
        Извлечен,
        [Description1C8(Name = "ИзвлечьНеУдалось", Comment = "", Synonym = "Извлечь не удалось")]
        ИзвлечьНеУдалось
    }
}

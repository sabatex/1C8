using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыИзвлеченияТекстаФайлов", Comment = "", Synonym = "Статусы извлечения текста файлов")]
    public class СтатусыИзвлеченияТекстаФайлов:EnumItem
    {
        public static readonly СтатусыИзвлеченияТекстаФайлов НеИзвлечен = new СтатусыИзвлеченияТекстаФайлов{Name= "НеИзвлечен",Synonim="Не извлечен",Comment=""};
        public static readonly СтатусыИзвлеченияТекстаФайлов Извлечен = new СтатусыИзвлеченияТекстаФайлов{Name= "Извлечен",Synonim="Извлечен",Comment=""};
        public static readonly СтатусыИзвлеченияТекстаФайлов ИзвлечьНеУдалось = new СтатусыИзвлеченияТекстаФайлов{Name= "ИзвлечьНеУдалось",Synonim="Извлечь не удалось",Comment=""};
    }
}

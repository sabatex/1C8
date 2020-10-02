using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыИзвлеченияТекстаФайлов", Comment = "", Synonym = "Статусы извлечения текста файлов")]
    public class СтатусыИзвлеченияТекстаФайлов:EnumItem
    {
        public static readonly СтатусыИзвлеченияТекстаФайлов НеИзвлечен = new СтатусыИзвлеченияТекстаФайлов{Name= "НеИзвлечен",Synonym="Не извлечен",Comment=""};
        public static readonly СтатусыИзвлеченияТекстаФайлов Извлечен = new СтатусыИзвлеченияТекстаФайлов{Name= "Извлечен",Synonym="Извлечен",Comment=""};
        public static readonly СтатусыИзвлеченияТекстаФайлов ИзвлечьНеУдалось = new СтатусыИзвлеченияТекстаФайлов{Name= "ИзвлечьНеУдалось",Synonym="Извлечь не удалось",Comment=""};
    }
}

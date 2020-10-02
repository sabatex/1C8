using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыВерсионированияОбъектов", Comment = "", Synonym = "Варианты версионирования объектов")]
    public class ВариантыВерсионированияОбъектов:EnumItem
    {
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриЗаписи = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриЗаписи",Synonym="При записи",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриПроведении = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриПроведении",Synonym="При проведении",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриСтарте = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриСтарте",Synonym="При старте",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов НеВерсионировать = new ВариантыВерсионированияОбъектов{Name= "НеВерсионировать",Synonym="Никогда",Comment=""};
    }
}

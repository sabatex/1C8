using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыВерсионированияОбъектов", Comment = "", Synonym = "Варианты версионирования объектов")]
    public class ВариантыВерсионированияОбъектов:EnumItem
    {
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриЗаписи = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриЗаписи",Synonim="При записи",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриПроведении = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриПроведении",Synonim="При проведении",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов ВерсионироватьПриСтарте = new ВариантыВерсионированияОбъектов{Name= "ВерсионироватьПриСтарте",Synonim="При старте",Comment=""};
        public static readonly ВариантыВерсионированияОбъектов НеВерсионировать = new ВариантыВерсионированияОбъектов{Name= "НеВерсионировать",Synonim="Никогда",Comment=""};
    }
}

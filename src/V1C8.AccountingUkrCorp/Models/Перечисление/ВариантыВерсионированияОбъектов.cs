using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыВерсионированияОбъектов", Comment = "", Synonym = "Варианты версионирования объектов")]
    public enum ВариантыВерсионированияОбъектов
    {
        [Description1C8(Name = "ВерсионироватьПриЗаписи", Comment = "", Synonym = "При записи")]
        ВерсионироватьПриЗаписи,
        [Description1C8(Name = "ВерсионироватьПриПроведении", Comment = "", Synonym = "При проведении")]
        ВерсионироватьПриПроведении,
        [Description1C8(Name = "ВерсионироватьПриСтарте", Comment = "", Synonym = "При старте")]
        ВерсионироватьПриСтарте,
        [Description1C8(Name = "НеВерсионировать", Comment = "", Synonym = "Никогда")]
        НеВерсионировать
    }
}

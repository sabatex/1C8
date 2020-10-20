using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("PredopredelennyeVaryantyOtchetov")]
    [Description1C8(Name = "ПредопределенныеВариантыОтчетов", Comment = "Предопределенные варианты отчетов конфигурации", Synonym = "Предопределенные варианты отчетов")]
    public class ПредопределенныеВариантыОтчетов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Отчет {get; set;}
        [Description1C8(Name = "КлючВарианта", Comment = "", Synonym = "Ключ варианта")]
        [StringLength(256)]
        public string КлючВарианта {get; set;}
        [Description1C8(Name = "Включен", Comment = "", Synonym = "Включен")]
        public bool Включен {get; set;}
        [Description1C8(Name = "ГруппироватьПоОтчету", Comment = "", Synonym = "Группировать по отчету")]
        public bool ГруппироватьПоОтчету {get; set;}
        [Description1C8(Name = "ВидимостьПоУмолчанию", Comment = "", Synonym = "Видимость по умолчанию")]
        public bool ВидимостьПоУмолчанию {get; set;}
        [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
        public string Описание {get; set;}
        [Description1C8(Name = "ХешНастроек", Comment = "", Synonym = "Хеш настроек")]
        [StringLength(32)]
        public string ХешНастроек {get; set;}
        [Description1C8(Name = "НаименованияПолей", Comment = "", Synonym = "Наименования полей")]
        public string НаименованияПолей {get; set;}
        [Description1C8(Name = "НаименованияПараметровИОтборов", Comment = "", Synonym = "Наименования параметров и отборов")]
        public string НаименованияПараметровИОтборов {get; set;}
        [Description1C8(Name = "КлючевыеСлова", Comment = "", Synonym = "Ключевые слова")]
        public string КлючевыеСлова {get; set;}
        [Description1C8(Name = "КлючЗамеров", Comment = "", Synonym = "Ключ замеров")]
        [StringLength(135)]
        public string КлючЗамеров {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Размещение", Comment = "", Synonym = "Размещение")]
        public List<ПредопределенныеВариантыОтчетов_Размещение> ПредопределенныеВариантыОтчетовРазмещение {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Размещение", Comment = "", Synonym = "Размещение")]
    [Table("PredopredelennyeVaryantyOtchetov_Razmeshchenye")]
    public class ПредопределенныеВариантыОтчетов_Размещение
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Подсистема", Comment = "", Synonym = "Подсистема")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Подсистема {get; set;}
        [Description1C8(Name = "Важный", Comment = "", Synonym = "Важный")]
        public bool Важный {get; set;}
        [Description1C8(Name = "СмТакже", Comment = "Вариант находится в группе 'См. также'", Synonym = "См также")]
        public bool СмТакже {get; set;}
    }
}

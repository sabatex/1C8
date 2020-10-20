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
    [Table("TaryfyPlatezhnykhAhentov")]
    [Description1C8(Name = "ТарифыПлатежныхАгентов", Comment = "", Synonym = "Тарифы платежных агентов")]
    public class ТарифыПлатежныхАгентов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ИспользуетсяШкала", Comment = "", Synonym = "Использовать шкалу")]
        public bool ИспользуетсяШкала {get; set;}
        [Description1C8(Name = "СпособВводаСуммы", Comment = "Способ ввода суммы по тарифу. 0 — процент взимается с полной суммы перевода, 1 — процент взимается с суммы перевода, превышающей предыдущий порог", Synonym = "Способ ввода суммы")]
        // Format 1.0
        public long СпособВводаСуммы {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Шкала", Comment = "", Synonym = "Шкала")]
        public List<ТарифыПлатежныхАгентов_Шкала> ТарифыПлатежныхАгентовШкала {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Шкала", Comment = "", Synonym = "Шкала")]
    [Table("TaryfyPlatezhnykhAhentov_Shkala")]
    public class ТарифыПлатежныхАгентов_Шкала
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Порог", Comment = "", Synonym = "Сумма перевода")]
        // Format 15.2
        public decimal Порог {get; set;}
        [Description1C8(Name = "Процент", Comment = "", Synonym = "Процент")]
        // Format 4.2
        public decimal Процент {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "МинимальнаяСумма", Comment = "", Synonym = "Минимальный размер")]
        // Format 15.2
        public decimal МинимальнаяСумма {get; set;}
        [Description1C8(Name = "МаксимальнаяСумма", Comment = "", Synonym = "Максимальный размер")]
        // Format 15.2
        public decimal МаксимальнаяСумма {get; set;}
    }
}

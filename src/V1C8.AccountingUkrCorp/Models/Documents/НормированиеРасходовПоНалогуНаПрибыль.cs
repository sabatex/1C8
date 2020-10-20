using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("NormyrovanyeRaskhodovPoNalohuNaPrybyl")]
    [Description1C8(Name = "НормированиеРасходовПоНалогуНаПрибыль", Comment = "", Synonym = "Нормирование расходов по налогу на прибыль")]
    public class НормированиеРасходовПоНалогуНаПрибыль:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ОблагаемаяПрибыльПрошлогоГода", Comment = "", Synonym = "Облагаемая прибыль прошлого года")]
        // Format 15.2
        public decimal ОблагаемаяПрибыльПрошлогоГода {get; set;}
        [Description1C8(Name = "ВыручкаПрошлогоГода", Comment = "", Synonym = "Выручка прошлого года")]
        // Format 15.2
        public decimal ВыручкаПрошлогоГода {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
        public List<НормированиеРасходовПоНалогуНаПрибыль_Статьи> НормированиеРасходовПоНалогуНаПрибыльСтатьи {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
    [Table("NormyrovanyeRaskhodovPoNalohuNaPrybyl_Staty")]
    public class НормированиеРасходовПоНалогуНаПрибыль_Статьи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Статья", Comment = "", Synonym = "Статья")]
        public Catalogs.СтатьиНалоговыхДеклараций Статья {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СуммаОборот", Comment = "", Synonym = "Сумма затрат")]
        // Format 15.2
        public decimal СуммаОборот {get; set;}
        [Description1C8(Name = "СуммаВПределелахНорм", Comment = "", Synonym = "Сумма в пределелах норм")]
        // Format 15.2
        public decimal СуммаВПределелахНорм {get; set;}
    }
}

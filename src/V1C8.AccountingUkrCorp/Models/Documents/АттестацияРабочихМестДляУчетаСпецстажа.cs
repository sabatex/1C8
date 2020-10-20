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
    [Table("AttestatsyiaRabochykhMestDliaUchetaSpetsstazha")]
    [Description1C8(Name = "АттестацияРабочихМестДляУчетаСпецстажа", Comment = "", Synonym = "Аттестация рабочих мест для учета спецстажа")]
    public class АттестацияРабочихМестДляУчетаСпецстажа:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ШтатныеЕдиницы", Comment = "", Synonym = "Штатные единицы")]
        public List<АттестацияРабочихМестДляУчетаСпецстажа_ШтатныеЕдиницы> АттестацияРабочихМестДляУчетаСпецстажаШтатныеЕдиницы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШтатныеЕдиницы", Comment = "", Synonym = "Штатные единицы")]
    [Table("AttestatsyiaRabochykhMestDliaUchetaSpetsstazha_ShtatnyeEdynytsy")]
    public class АттестацияРабочихМестДляУчетаСпецстажа_ШтатныеЕдиницы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ШтатноеРасписание", Comment = "", Synonym = "Штатное расписание")]
        public Catalogs.ШтатноеРасписание ШтатноеРасписание {get; set;}
        [Description1C8(Name = "ОснованиеСпецСтажа", Comment = "", Synonym = "Основание спец стажа")]
        public Catalogs.ОснованияСпециальногоСтажа ОснованиеСпецСтажа {get; set;}
        [Description1C8(Name = "Актуальность", Comment = "", Synonym = "Актуальность")]
        public bool Актуальность {get; set;}
        [Description1C8(Name = "ЕдиницаВремени", Comment = "", Synonym = "Единица времени")]
        public Enums.ЕдиницыВремениУчетаСпецстажа ЕдиницаВремени {get; set;}
        [Description1C8(Name = "ГрафикНормы", Comment = "", Synonym = "График нормы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикНормы {get; set;}
        [Description1C8(Name = "Сезонность", Comment = "", Synonym = "Сезонность")]
        public bool Сезонность {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
    }
}

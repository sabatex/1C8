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
    [Table("DokumentRaschetovSKontrahentom")]
    [Description1C8(Name = "ДокументРасчетовСКонтрагентом", Comment = "", Synonym = "Документ расчетов с контрагентом (ручной учет)")]
    public class ДокументРасчетовСКонтрагентом:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.СторнированиеНачислений ДокументОснование {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Вх. номер")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Вх. дата")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "УдалитьСчетУчетаРасчетовСКомитентом", Comment = "", Synonym = "(не используется) Счет учета расчетов с комитентом")]
        public ПланСчетов.Хозрасчетный УдалитьСчетУчетаРасчетовСКомитентом {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

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
    [Table("StatyZatrat")]
    [Description1C8(Name = "СтатьиЗатрат", Comment = "(Общ)", Synonym = "Статьи затрат")]
    public class СтатьиЗатрат:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПостояннаяЗатрата", Comment = "", Synonym = "Постоянная затрата")]
        public bool ПостояннаяЗатрата {get; set;}
        [Description1C8(Name = "ВидЗатрат", Comment = "(Общ)", Synonym = "Вид затрат")]
        public Enums.ВидыЗатрат ВидЗатрат {get; set;}
        [Description1C8(Name = "Счет8Класса", Comment = "", Synonym = "Счет 8 класса")]
        public ПланСчетов.Хозрасчетный Счет8Класса {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоНалогуНаПрибыль", Comment = "", Synonym = "Ст. декл. по налогу на прибыль (до 01.01.2015)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоНалогуНаПрибыль {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

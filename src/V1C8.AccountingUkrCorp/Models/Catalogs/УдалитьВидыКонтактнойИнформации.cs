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
    [Table("UdalytVydyKontaktnoiYnformatsyy")]
    [Description1C8(Name = "УдалитьВидыКонтактнойИнформации", Comment = "", Synonym = "(не используется) Виды контактной информации")]
    public class УдалитьВидыКонтактнойИнформации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ТипыКонтактнойИнформации Тип {get; set;}
        [Description1C8(Name = "ВидОбъектаКонтактнойИнформации", Comment = "", Synonym = "Вид объекта контактной информации")]
        public Enums.УдалитьВидыОбъектовКонтактнойИнформации ВидОбъектаКонтактнойИнформации {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

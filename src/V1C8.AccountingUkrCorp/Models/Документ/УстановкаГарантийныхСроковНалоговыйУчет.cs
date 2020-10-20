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
    [Table("UstanovkaHarantyinykhSrokovNalohovyiUchet")]
    [Description1C8(Name = "УстановкаГарантийныхСроковНалоговыйУчет", Comment = "", Synonym = "Установка гарантийных сроков (налоговый учет)")]
    public class УстановкаГарантийныхСроковНалоговыйУчет:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ГарантийныеСроки", Comment = "", Synonym = "Гарантийные сроки")]
        public List<УстановкаГарантийныхСроковНалоговыйУчет_ГарантийныеСроки> УстановкаГарантийныхСроковНалоговыйУчетГарантийныеСроки {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ГарантийныеСроки", Comment = "", Synonym = "Гарантийные сроки")]
    [Table("UstanovkaHarantyinykhSrokovNalohovyiUchet_HarantyinyeSroky")]
    public class УстановкаГарантийныхСроковНалоговыйУчет_ГарантийныеСроки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "Срок", Comment = "", Synonym = "Срок (месяцев)")]
        // Format 10.0
        public long Срок {get; set;}
    }
}

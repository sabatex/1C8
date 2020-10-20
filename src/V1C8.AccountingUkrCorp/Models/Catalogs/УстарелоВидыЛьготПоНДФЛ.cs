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
    [Table("UstareloVydyLhotPoNDFL")]
    [Description1C8(Name = "УстарелоВидыЛьготПоНДФЛ", Comment = "", Synonym = "ѳ(устарело) Виды льгот по НДФЛ")]
    public class УстарелоВидыЛьготПоНДФЛ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "КодОтчетностиНДФЛ", Comment = "", Synonym = "Код отчетности НДФЛ")]
        [StringLength(2)]
        public string КодОтчетностиНДФЛ {get; set;}
        [Description1C8(Name = "РазмерНДФЛ", Comment = "( 1; 1,5; 2 )", Synonym = "Размер льготы НДФЛ")]
        // Format 5.2
        public decimal РазмерНДФЛ {get; set;}
        [Description1C8(Name = "СпособПримененияНДФЛ", Comment = "", Synonym = "Способ применения НДФЛ")]
        public Enums.СпособыПримененияЛьготРаботников СпособПримененияНДФЛ {get; set;}
        [Description1C8(Name = "УДАЛИТЬПунктЗаконаНДФЛ", Comment = "", Synonym = "(не используется) Пункт Закона об НДФЛ")]
        [StringLength(7)]
        public string УДАЛИТЬПунктЗаконаНДФЛ {get; set;}
        [Description1C8(Name = "ГруппаЛьгот", Comment = "", Synonym = "Группа льгот")]
        public bool ГруппаЛьгот {get; set;}
        [Description1C8(Name = "Льгота1", Comment = "", Synonym = "Льгота 1")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота1 {get; set;}
        [Description1C8(Name = "Льгота2", Comment = "", Synonym = "Льгота 2")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота2 {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

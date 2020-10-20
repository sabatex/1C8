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
    [Table("UsluhyServysa")]
    [Description1C8(Name = "УслугиСервиса", Comment = "", Synonym = "Услуги сервиса")]
    public class УслугиСервиса:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
        [StringLength(50)]
        public string Идентификатор {get; set;}
        [Description1C8(Name = "ПоказыватьПриДобавленииВТариф", Comment = "", Synonym = "Показывать при добавлении в тариф")]
        public bool ПоказыватьПриДобавленииВТариф {get; set;}
        [Description1C8(Name = "ПоставщикУслуги", Comment = "", Synonym = "Поставщик услуги")]
        public Catalogs.ПоставщикиУслугСервиса ПоставщикУслуги {get; set;}
        [Description1C8(Name = "Тарифицируется", Comment = "", Synonym = "Тарифицируется")]
        public bool Тарифицируется {get; set;}
        [Description1C8(Name = "ТипУслуги", Comment = "", Synonym = "Тип услуги")]
        public Enums.ТипыУслуг ТипУслуги {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

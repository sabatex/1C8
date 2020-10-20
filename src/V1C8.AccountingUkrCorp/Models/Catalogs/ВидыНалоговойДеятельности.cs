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
    [Table("VydyNalohovoiDeiatelnosty")]
    [Description1C8(Name = "ВидыНалоговойДеятельности", Comment = "(Регл) Виды деятельности по налогу на прибыль", Synonym = "Виды налоговой деятельности")]
    public class ВидыНалоговойДеятельности:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ТипНалоговойДеятельности", Comment = "", Synonym = "Тип деятельности")]
        public Enums.ТипНалоговойДеятельности ТипНалоговойДеятельности {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}

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
    [Table("HruppyPolzovatelei")]
    [Description1C8(Name = "ГруппыПользователей", Comment = "", Synonym = "Группы пользователей")]
    public class ГруппыПользователей:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Состав", Comment = "", Synonym = "Участники группы")]
        public List<ГруппыПользователей_Состав> ГруппыПользователейСостав {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Участники группы")]
    [Table("HruppyPolzovatelei_Sostav")]
    public class ГруппыПользователей_Состав
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
        public Catalogs.Пользователи Пользователь {get; set;}
    }
}

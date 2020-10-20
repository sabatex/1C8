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
    [Table("VyrabotkaNMA")]
    [Description1C8(Name = "ВыработкаНМА", Comment = "(Регл)", Synonym = "Выработка НМА")]
    public class ВыработкаНМА:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<ВыработкаНМА_НМА> ВыработкаНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("VyrabotkaNMA_NMA")]
    public class ВыработкаНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Объем работ")]
        // Format 15.3
        public decimal Количество {get; set;}
    }
}

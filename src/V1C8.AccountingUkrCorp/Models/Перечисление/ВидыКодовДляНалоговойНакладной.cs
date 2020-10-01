using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКодовДляНалоговойНакладной", Comment = "", Synonym = "Виды кодов для налоговой накладной")]
    public enum ВидыКодовДляНалоговойНакладной
    {
        [Description1C8(Name = "КодТовара", Comment = "", Synonym = "Товар")]
        КодТовара,
        [Description1C8(Name = "КодТовараИмпортированного", Comment = "", Synonym = "Импортированный товар")]
        КодТовараИмпортированного,
        [Description1C8(Name = "КодУслуги", Comment = "", Synonym = "Услуга")]
        КодУслуги
    }
}

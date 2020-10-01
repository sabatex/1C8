using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВерсииПодсистемыОбменаДанными", Comment = "", Synonym = "Версии подсистемы обмена данными")]
    public enum ВерсииПодсистемыОбменаДанными
    {
        [Description1C8(Name = "Версия10", Comment = "", Synonym = "Версия 1.0")]
        Версия10,
        [Description1C8(Name = "Версия20", Comment = "", Synonym = "Версия 2.0")]
        Версия20,
        [Description1C8(Name = "Версия30", Comment = "", Synonym = "Версия 3.0")]
        Версия30
    }
}

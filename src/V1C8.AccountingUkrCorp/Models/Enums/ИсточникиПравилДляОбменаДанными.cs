using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ИсточникиПравилДляОбменаДанными", Comment = "", Synonym = "Источники правил для обмена данными")]
    public class ИсточникиПравилДляОбменаДанными:EnumItem
    {
        public static readonly ИсточникиПравилДляОбменаДанными МакетКонфигурации = new ИсточникиПравилДляОбменаДанными{Name= "МакетКонфигурации",Synonim="Макет конфигурации",Comment=""};
        public static readonly ИсточникиПравилДляОбменаДанными Файл = new ИсточникиПравилДляОбменаДанными{Name= "Файл",Synonim="Файл",Comment=""};
    }
}

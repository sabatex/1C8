using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыБазыУдержанияПоИсполнительномуДокументу", Comment = "", Synonym = "Виды базы удержания по исполнительному документу")]
    public class ВидыБазыУдержанияПоИсполнительномуДокументу:EnumItem
    {
        public static readonly ВидыБазыУдержанияПоИсполнительномуДокументу Заработок = new ВидыБазыУдержанияПоИсполнительномуДокументу{Name= "Заработок",Synonim="Заработок",Comment=""};
        public static readonly ВидыБазыУдержанияПоИсполнительномуДокументу ПрожиточныйМинимум = new ВидыБазыУдержанияПоИсполнительномуДокументу{Name= "ПрожиточныйМинимум",Synonim="Прожиточный минимум",Comment=""};
    }
}

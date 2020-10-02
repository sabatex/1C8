using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаУдержанияПоИсполнительномуДокументу", Comment = "", Synonym = "Способы расчета удержания по исполнительному документу")]
    public class СпособыРасчетаУдержанияПоИсполнительномуДокументу:EnumItem
    {
        public static readonly СпособыРасчетаУдержанияПоИсполнительномуДокументу Процентом = new СпособыРасчетаУдержанияПоИсполнительномуДокументу{Name= "Процентом",Synonim="Процентом",Comment=""};
        public static readonly СпособыРасчетаУдержанияПоИсполнительномуДокументу Долей = new СпособыРасчетаУдержанияПоИсполнительномуДокументу{Name= "Долей",Synonim="Долей",Comment=""};
        public static readonly СпособыРасчетаУдержанияПоИсполнительномуДокументу ФиксированнойСуммой = new СпособыРасчетаУдержанияПоИсполнительномуДокументу{Name= "ФиксированнойСуммой",Synonim="Фиксированной суммой",Comment=""};
    }
}

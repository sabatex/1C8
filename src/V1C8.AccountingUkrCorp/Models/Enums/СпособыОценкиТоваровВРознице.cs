using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценкиТоваровВРознице", Comment = "(Общ)", Synonym = "Способы оценки товаров в рознице")]
    public class СпособыОценкиТоваровВРознице:EnumItem
    {
        public static readonly СпособыОценкиТоваровВРознице ПоСтоимостиПриобретения = new СпособыОценкиТоваровВРознице{Name= "ПоСтоимостиПриобретения",Synonim="По стоимости приобретения",Comment=""};
        public static readonly СпособыОценкиТоваровВРознице ПоПродажнойСтоимости = new СпособыОценкиТоваровВРознице{Name= "ПоПродажнойСтоимости",Synonim="По продажной стоимости",Comment=""};
    }
}

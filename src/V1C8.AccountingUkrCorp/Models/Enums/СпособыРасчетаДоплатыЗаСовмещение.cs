using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаДоплатыЗаСовмещение", Comment = "", Synonym = "Способы расчета доплаты за совмещение")]
    public class СпособыРасчетаДоплатыЗаСовмещение:EnumItem
    {
        public static readonly СпособыРасчетаДоплатыЗаСовмещение ПроцентФОТ = new СпособыРасчетаДоплатыЗаСовмещение{Name= "ПроцентФОТ",Synonim="Процент ФОТ",Comment=""};
        public static readonly СпособыРасчетаДоплатыЗаСовмещение РазницаФОТ = new СпособыРасчетаДоплатыЗаСовмещение{Name= "РазницаФОТ",Synonim="Разница ФОТ",Comment=""};
    }
}

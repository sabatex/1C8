using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаДоплатыЗаСовмещение", Comment = "", Synonym = "Способы расчета доплаты за совмещение")]
    public enum СпособыРасчетаДоплатыЗаСовмещение
    {
        [Description1C8(Name = "ПроцентФОТ", Comment = "", Synonym = "Процент ФОТ")]
        ПроцентФОТ,
        [Description1C8(Name = "РазницаФОТ", Comment = "", Synonym = "Разница ФОТ")]
        РазницаФОТ
    }
}

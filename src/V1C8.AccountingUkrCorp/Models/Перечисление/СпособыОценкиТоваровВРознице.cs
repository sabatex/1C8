using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценкиТоваровВРознице", Comment = "(Общ)", Synonym = "Способы оценки товаров в рознице")]
    public enum СпособыОценкиТоваровВРознице
    {
        [Description1C8(Name = "ПоСтоимостиПриобретения", Comment = "", Synonym = "По стоимости приобретения")]
        ПоСтоимостиПриобретения,
        [Description1C8(Name = "ПоПродажнойСтоимости", Comment = "", Synonym = "По продажной стоимости")]
        ПоПродажнойСтоимости
    }
}

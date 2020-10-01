using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыЗаполненияГрафикаРаботы", Comment = "", Synonym = "Способы заполнения графика работы")]
    public enum СпособыЗаполненияГрафикаРаботы
    {
        [Description1C8(Name = "ПоНеделям", Comment = "", Synonym = "По неделям")]
        ПоНеделям,
        [Description1C8(Name = "ПоЦикламПроизвольнойДлины", Comment = "", Synonym = "По циклам произвольной длины")]
        ПоЦикламПроизвольнойДлины
    }
}

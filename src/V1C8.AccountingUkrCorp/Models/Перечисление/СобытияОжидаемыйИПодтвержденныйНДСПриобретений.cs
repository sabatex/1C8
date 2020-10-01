using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияОжидаемыйИПодтвержденныйНДСПриобретений", Comment = "(Регл)", Synonym = "События ожидаемый и подтвержденный НДСПриобретений")]
    public enum СобытияОжидаемыйИПодтвержденныйНДСПриобретений
    {
        [Description1C8(Name = "Поступление", Comment = "", Synonym = "Поступление")]
        Поступление,
        [Description1C8(Name = "Возврат", Comment = "", Synonym = "Возврат")]
        Возврат
    }
}

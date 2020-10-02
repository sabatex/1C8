using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияОжидаемыйИПодтвержденныйНДСПриобретений", Comment = "(Регл)", Synonym = "События ожидаемый и подтвержденный НДСПриобретений")]
    public class СобытияОжидаемыйИПодтвержденныйНДСПриобретений:EnumItem
    {
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПриобретений Поступление = new СобытияОжидаемыйИПодтвержденныйНДСПриобретений{Name= "Поступление",Synonim="Поступление",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПриобретений Возврат = new СобытияОжидаемыйИПодтвержденныйНДСПриобретений{Name= "Возврат",Synonim="Возврат",Comment=""};
    }
}

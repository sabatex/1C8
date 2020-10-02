using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияОжидаемыйИПодтвержденныйНДСПродаж", Comment = "(Регл)", Synonym = "События ожидаемый и подтвержденный НДСПродаж")]
    public class СобытияОжидаемыйИПодтвержденныйНДСПродаж:EnumItem
    {
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж Реализация = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "Реализация",Synonim="Реализация",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж Возврат = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "Возврат",Synonim="Возврат",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж РеализацияРозница = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "РеализацияРозница",Synonim="Реализация розница",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж ВозвратРозница = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "ВозвратРозница",Synonim="Возврат розница",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж УсловнаяПродажа = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "УсловнаяПродажа",Synonim="Условная продажа",Comment=""};
        public static readonly СобытияОжидаемыйИПодтвержденныйНДСПродаж УсловнаяПродажаВозврат = new СобытияОжидаемыйИПодтвержденныйНДСПродаж{Name= "УсловнаяПродажаВозврат",Synonim="Условная продажа - возврат",Comment=""};
    }
}

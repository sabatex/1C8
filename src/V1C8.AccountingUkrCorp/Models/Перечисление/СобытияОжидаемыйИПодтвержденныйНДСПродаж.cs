using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияОжидаемыйИПодтвержденныйНДСПродаж", Comment = "(Регл)", Synonym = "События ожидаемый и подтвержденный НДСПродаж")]
    public enum СобытияОжидаемыйИПодтвержденныйНДСПродаж
    {
        [Description1C8(Name = "Реализация", Comment = "", Synonym = "Реализация")]
        Реализация,
        [Description1C8(Name = "Возврат", Comment = "", Synonym = "Возврат")]
        Возврат,
        [Description1C8(Name = "РеализацияРозница", Comment = "", Synonym = "Реализация розница")]
        РеализацияРозница,
        [Description1C8(Name = "ВозвратРозница", Comment = "", Synonym = "Возврат розница")]
        ВозвратРозница,
        [Description1C8(Name = "УсловнаяПродажа", Comment = "", Synonym = "Условная продажа")]
        УсловнаяПродажа,
        [Description1C8(Name = "УсловнаяПродажаВозврат", Comment = "", Synonym = "Условная продажа - возврат")]
        УсловнаяПродажаВозврат
    }
}

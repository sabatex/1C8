using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "БазаРаспределенияВнутреннихУслуг", Comment = "База распределения внутренних услуг", Synonym = "База распределения внутренних услуг")]
    public enum БазаРаспределенияВнутреннихУслуг
    {
        [Description1C8(Name = "ПлановаяСебестоимость", Comment = "", Synonym = "Плановая себестоимость")]
        ПлановаяСебестоимость,
        [Description1C8(Name = "НатуральныеПоказатели", Comment = "", Synonym = "Натуральные показатели")]
        НатуральныеПоказатели
    }
}

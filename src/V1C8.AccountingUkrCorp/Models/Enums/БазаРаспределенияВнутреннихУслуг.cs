using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("BazaRaspredelenyiaVnutrennykhUsluh")]
    [Description1C8(Name = "БазаРаспределенияВнутреннихУслуг", Comment = "База распределения внутренних услуг", Synonym = "База распределения внутренних услуг")]
    public class БазаРаспределенияВнутреннихУслуг:EnumItem
    {
        public static readonly БазаРаспределенияВнутреннихУслуг ПлановаяСебестоимость = new БазаРаспределенияВнутреннихУслуг{Name= "ПлановаяСебестоимость",Synonym="Плановая себестоимость",Comment=""};
        public static readonly БазаРаспределенияВнутреннихУслуг НатуральныеПоказатели = new БазаРаспределенияВнутреннихУслуг{Name= "НатуральныеПоказатели",Synonym="Натуральные показатели",Comment=""};
    }
}

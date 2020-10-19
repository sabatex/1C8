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
    [Table("SposobyRaschetaDoplatyZaSovmeshchenye")]
    [Description1C8(Name = "СпособыРасчетаДоплатыЗаСовмещение", Comment = "", Synonym = "Способы расчета доплаты за совмещение")]
    public class СпособыРасчетаДоплатыЗаСовмещение:EnumItem
    {
        public static readonly СпособыРасчетаДоплатыЗаСовмещение ПроцентФОТ = new СпособыРасчетаДоплатыЗаСовмещение{Name= "ПроцентФОТ",Synonym="Процент ФОТ",Comment=""};
        public static readonly СпособыРасчетаДоплатыЗаСовмещение РазницаФОТ = new СпособыРасчетаДоплатыЗаСовмещение{Name= "РазницаФОТ",Synonym="Разница ФОТ",Comment=""};
    }
}

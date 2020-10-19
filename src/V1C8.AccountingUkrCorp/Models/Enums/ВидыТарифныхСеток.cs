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
    [Table("VydyTaryfnykhSetok")]
    [Description1C8(Name = "ВидыТарифныхСеток", Comment = "", Synonym = "Виды тарифных сеток")]
    public class ВидыТарифныхСеток:EnumItem
    {
        public static readonly ВидыТарифныхСеток Тариф = new ВидыТарифныхСеток{Name= "Тариф",Synonym="Тариф",Comment=""};
        public static readonly ВидыТарифныхСеток Надбавка = new ВидыТарифныхСеток{Name= "Надбавка",Synonym="Надбавка",Comment=""};
    }
}

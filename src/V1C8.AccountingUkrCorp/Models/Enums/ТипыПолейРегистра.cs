using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПолейРегистра", Comment = "", Synonym = "Типы полей регистра")]
    public class ТипыПолейРегистра:EnumItem
    {
        public static readonly ТипыПолейРегистра Измерение = new ТипыПолейРегистра{Name= "Измерение",Synonim="Измерение",Comment=""};
        public static readonly ТипыПолейРегистра Ресурс = new ТипыПолейРегистра{Name= "Ресурс",Synonim="Ресурс",Comment=""};
        public static readonly ТипыПолейРегистра Реквизит = new ТипыПолейРегистра{Name= "Реквизит",Synonim="Реквизит",Comment=""};
    }
}

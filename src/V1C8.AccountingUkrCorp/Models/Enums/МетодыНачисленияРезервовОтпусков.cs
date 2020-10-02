using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МетодыНачисленияРезервовОтпусков", Comment = "", Synonym = "Методы начисления резервов отпусков")]
    public class МетодыНачисленияРезервовОтпусков:EnumItem
    {
        public static readonly МетодыНачисленияРезервовОтпусков МетодОбязательств = new МетодыНачисленияРезервовОтпусков{Name= "МетодОбязательств",Synonim="Метод обязательств (МСФО)",Comment=""};
        public static readonly МетодыНачисленияРезервовОтпусков НормативныйМетод = new МетодыНачисленияРезервовОтпусков{Name= "НормативныйМетод",Synonim="Нормативный метод",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МетодыНачисленияРезервовОтпусков", Comment = "", Synonym = "Методы начисления резервов отпусков")]
    public enum МетодыНачисленияРезервовОтпусков
    {
        [Description1C8(Name = "МетодОбязательств", Comment = "", Synonym = "Метод обязательств (МСФО)")]
        МетодОбязательств,
        [Description1C8(Name = "НормативныйМетод", Comment = "", Synonym = "Нормативный метод")]
        НормативныйМетод
    }
}

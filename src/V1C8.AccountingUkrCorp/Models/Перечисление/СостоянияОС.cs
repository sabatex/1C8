using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияОС", Comment = "(Общ)", Synonym = "Состояния ОС")]
    public enum СостоянияОС
    {
        [Description1C8(Name = "ВведеноВЭксплуатацию", Comment = "(Общ)", Synonym = "Введено в эксплуатацию")]
        ВведеноВЭксплуатацию,
        [Description1C8(Name = "СнятоСУчета", Comment = "(Общ)", Synonym = "Снято с учета")]
        СнятоСУчета
    }
}

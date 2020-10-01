using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныИзмененияСостояния", Comment = "(Общ)", Synonym = "Причины изменения состояния")]
    public enum ПричиныИзмененияСостояния
    {
        [Description1C8(Name = "ПриемНаРаботу", Comment = "(Общ)", Synonym = "Прием на работу")]
        ПриемНаРаботу,
        [Description1C8(Name = "Перемещение", Comment = "(Общ)", Synonym = "Перемещение")]
        Перемещение,
        [Description1C8(Name = "Увольнение", Comment = "(Общ)", Synonym = "Увольнение")]
        Увольнение
    }
}

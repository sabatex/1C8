using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЗатрат", Comment = "(Общ)", Synonym = "Виды затрат")]
    public enum ВидыЗатрат
    {
        [Description1C8(Name = "Материальные", Comment = "(Общ)", Synonym = "Материальные")]
        Материальные,
        [Description1C8(Name = "ОплатаТруда", Comment = "(Общ)", Synonym = "Оплата труда")]
        ОплатаТруда,
        [Description1C8(Name = "ОтчисленияНаСоциальныеНужды", Comment = "", Synonym = "Отчисления на социальные нужды")]
        ОтчисленияНаСоциальныеНужды,
        [Description1C8(Name = "Амортизация", Comment = "(Общ)", Synonym = "Амортизация")]
        Амортизация,
        [Description1C8(Name = "Прочие", Comment = "(Общ)", Synonym = "Прочие")]
        Прочие
    }
}

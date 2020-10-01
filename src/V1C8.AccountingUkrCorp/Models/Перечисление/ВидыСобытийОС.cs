using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСобытийОС", Comment = "(Регл)", Synonym = "Виды событий с основными средствами")]
    public enum ВидыСобытийОС
    {
        [Description1C8(Name = "ВводВЭксплуатацию", Comment = "", Synonym = "Ввод в эксплуатацию")]
        ВводВЭксплуатацию,
        [Description1C8(Name = "НачислениеАмортизации", Comment = "", Synonym = "Начисление амортизации")]
        НачислениеАмортизации,
        [Description1C8(Name = "ВнутреннееПеремещение", Comment = "", Synonym = "Внутреннее перемещение")]
        ВнутреннееПеремещение,
        [Description1C8(Name = "ЧастичнаяЛиквидация", Comment = "", Synonym = "Частичная ликвидация")]
        ЧастичнаяЛиквидация,
        [Description1C8(Name = "Модернизация", Comment = "", Synonym = "Модернизация и ремонт")]
        Модернизация,
        [Description1C8(Name = "ПодготовкаКПередаче", Comment = "", Synonym = "Подготовка к передаче")]
        ПодготовкаКПередаче,
        [Description1C8(Name = "Передача", Comment = "", Synonym = "Передача")]
        Передача,
        [Description1C8(Name = "Списание", Comment = "", Synonym = "Списание")]
        Списание,
        [Description1C8(Name = "Прочее", Comment = "Прочие состояния (пользовательские)", Synonym = "Прочее")]
        Прочее,
        [Description1C8(Name = "Ремонт", Comment = "", Synonym = "Ремонт")]
        Ремонт
    }
}

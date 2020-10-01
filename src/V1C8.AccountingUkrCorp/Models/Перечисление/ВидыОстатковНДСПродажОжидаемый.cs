using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПродажОжидаемый", Comment = "", Synonym = "Виды остатков ожидаемого НДС по продажам")]
    public enum ВидыОстатковНДСПродажОжидаемый
    {
        [Description1C8(Name = "ПравильнаяРегистрация", Comment = "", Synonym = "Правильное оформление нал. док-тов (корректируют неправильно оформленные)")]
        ПравильнаяРегистрация,
        [Description1C8(Name = "ЕщеНеВыписаны", Comment = "", Synonym = "Еще не выписанные нал. док-ты (не требуется корректировки)")]
        ЕщеНеВыписаны
    }
}

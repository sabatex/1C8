using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипНалоговойДеятельности", Comment = "", Synonym = "Тип налоговой деятельности")]
    public enum ТипНалоговойДеятельности
    {
        [Description1C8(Name = "ОблагаемыйПоОбычнойСтавке", Comment = "", Synonym = "Облагаемый по обычной ставке")]
        ОблагаемыйПоОбычнойСтавке,
        [Description1C8(Name = "ОсвобожденныйОтНалогообложения", Comment = "", Synonym = "Освобожденный от налогообложения")]
        ОсвобожденныйОтНалогообложения,
        [Description1C8(Name = "НеОблагаемый", Comment = "", Synonym = "Не облагаемый")]
        НеОблагаемый
    }
}

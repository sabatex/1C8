using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыОтчетовПоЗарплате", Comment = "", Synonym = "Разделы отчетов по зарплате")]
    public enum РазделыОтчетовПоЗарплате
    {
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        Начисления,
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        Удержания,
        [Description1C8(Name = "Выплаты", Comment = "", Synonym = "Выплаты")]
        Выплаты,
        [Description1C8(Name = "ДоходыВНеденежнойФорме", Comment = "", Synonym = "Доходы в неденежной форме")]
        ДоходыВНеденежнойФорме,
        [Description1C8(Name = "ПогашениеЗадолженности", Comment = "", Synonym = "Погашение задолженности")]
        ПогашениеЗадолженности
    }
}

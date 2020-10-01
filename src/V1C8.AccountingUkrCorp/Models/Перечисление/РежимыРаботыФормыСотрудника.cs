using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыРаботыФормыСотрудника", Comment = "", Synonym = "Режимы работы формы сотрудника")]
    public enum РежимыРаботыФормыСотрудника
    {
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        Сотрудник,
        [Description1C8(Name = "СотрудникОформленныйПоДоговоруГПХ", Comment = "", Synonym = "Сотрудник оформленный по договору ГПХ")]
        СотрудникОформленныйПоДоговоруГПХ,
        [Description1C8(Name = "СотрудникОформленныйПоТрудовомуДоговору", Comment = "", Synonym = "Сотрудник оформленный по трудовому договору")]
        СотрудникОформленныйПоТрудовомуДоговору,
        [Description1C8(Name = "СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ", Comment = "", Synonym = "Сотрудник оформленный по трудовому договору и договору ГПХ")]
        СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ,
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        ФизическоеЛицо
    }
}

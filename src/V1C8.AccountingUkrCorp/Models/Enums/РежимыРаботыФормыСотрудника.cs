using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыРаботыФормыСотрудника", Comment = "", Synonym = "Режимы работы формы сотрудника")]
    public class РежимыРаботыФормыСотрудника:EnumItem
    {
        public static readonly РежимыРаботыФормыСотрудника Сотрудник = new РежимыРаботыФормыСотрудника{Name= "Сотрудник",Synonim="Сотрудник",Comment=""};
        public static readonly РежимыРаботыФормыСотрудника СотрудникОформленныйПоДоговоруГПХ = new РежимыРаботыФормыСотрудника{Name= "СотрудникОформленныйПоДоговоруГПХ",Synonim="Сотрудник оформленный по договору ГПХ",Comment=""};
        public static readonly РежимыРаботыФормыСотрудника СотрудникОформленныйПоТрудовомуДоговору = new РежимыРаботыФормыСотрудника{Name= "СотрудникОформленныйПоТрудовомуДоговору",Synonim="Сотрудник оформленный по трудовому договору",Comment=""};
        public static readonly РежимыРаботыФормыСотрудника СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ = new РежимыРаботыФормыСотрудника{Name= "СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ",Synonim="Сотрудник оформленный по трудовому договору и договору ГПХ",Comment=""};
        public static readonly РежимыРаботыФормыСотрудника ФизическоеЛицо = new РежимыРаботыФормыСотрудника{Name= "ФизическоеЛицо",Synonim="Физическое лицо",Comment=""};
    }
}

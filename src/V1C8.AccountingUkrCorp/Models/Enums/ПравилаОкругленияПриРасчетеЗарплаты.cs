using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПравилаОкругленияПриРасчетеЗарплаты", Comment = "", Synonym = "Правила округления (для целей расчета зарплаты)")]
    public class ПравилаОкругленияПриРасчетеЗарплаты:EnumItem
    {
        public static readonly ПравилаОкругленияПриРасчетеЗарплаты Авто = new ПравилаОкругленияПриРасчетеЗарплаты{Name= "Авто",Synonim="Авто",Comment=""};
        public static readonly ПравилаОкругленияПриРасчетеЗарплаты ВМеньшуюСторону = new ПравилаОкругленияПриРасчетеЗарплаты{Name= "ВМеньшуюСторону",Synonim="В сторону уменьшения",Comment=""};
        public static readonly ПравилаОкругленияПриРасчетеЗарплаты ВБольшуюСторону = new ПравилаОкругленияПриРасчетеЗарплаты{Name= "ВБольшуюСторону",Synonim="В сторону увеличения",Comment=""};
    }
}

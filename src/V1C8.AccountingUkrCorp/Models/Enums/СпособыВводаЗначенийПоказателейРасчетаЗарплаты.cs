using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВводаЗначенийПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Способы ввода значений показателей расчета зарплаты")]
    public class СпособыВводаЗначенийПоказателейРасчетаЗарплаты:EnumItem
    {
        public static readonly СпособыВводаЗначенийПоказателейРасчетаЗарплаты ВводитсяЕдиновременно = new СпособыВводаЗначенийПоказателейРасчетаЗарплаты{Name= "ВводитсяЕдиновременно",Synonym="Вводится единовременно",Comment=""};
        public static readonly СпособыВводаЗначенийПоказателейРасчетаЗарплаты НакапливаетсяПоОтдельнымЗначениям = new СпособыВводаЗначенийПоказателейРасчетаЗарплаты{Name= "НакапливаетсяПоОтдельнымЗначениям",Synonym="Накапливается по отдельным значениям",Comment=""};
        public static readonly СпособыВводаЗначенийПоказателейРасчетаЗарплаты ВводитсяПриРасчете = new СпособыВводаЗначенийПоказателейРасчетаЗарплаты{Name= "ВводитсяПриРасчете",Synonym="Вводится при расчете",Comment=""};
    }
}

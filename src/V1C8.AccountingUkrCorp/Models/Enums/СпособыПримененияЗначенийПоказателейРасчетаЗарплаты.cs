using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПримененияЗначенийПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Способы применения значений показателей расчета зарплаты")]
    public class СпособыПримененияЗначенийПоказателейРасчетаЗарплаты:EnumItem
    {
        public static readonly СпособыПримененияЗначенийПоказателейРасчетаЗарплаты Постоянное = new СпособыПримененияЗначенийПоказателейРасчетаЗарплаты{Name= "Постоянное",Synonim="Во всех месяцах после ввода значения (постоянное использование)",Comment=""};
        public static readonly СпособыПримененияЗначенийПоказателейРасчетаЗарплаты Разовое = new СпособыПримененияЗначенийПоказателейРасчетаЗарплаты{Name= "Разовое",Synonim="Только в месяце, в котором вводится значение (разовое использование)",Comment=""};
    }
}

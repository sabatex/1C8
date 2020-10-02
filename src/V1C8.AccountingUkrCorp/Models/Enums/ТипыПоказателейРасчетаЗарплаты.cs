using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Типы показателей расчета зарплаты")]
    public class ТипыПоказателейРасчетаЗарплаты:EnumItem
    {
        public static readonly ТипыПоказателейРасчетаЗарплаты Денежный = new ТипыПоказателейРасчетаЗарплаты{Name= "Денежный",Synonim="Денежный",Comment=""};
        public static readonly ТипыПоказателейРасчетаЗарплаты Числовой = new ТипыПоказателейРасчетаЗарплаты{Name= "Числовой",Synonim="Числовой",Comment=""};
        public static readonly ТипыПоказателейРасчетаЗарплаты ЧисловойЗависящийОтДругогоПоказателя = new ТипыПоказателейРасчетаЗарплаты{Name= "ЧисловойЗависящийОтДругогоПоказателя",Synonim="Числовой, зависящий от другого показателя",Comment=""};
        public static readonly ТипыПоказателейРасчетаЗарплаты ЧисловойЗависящийОтСтажа = new ТипыПоказателейРасчетаЗарплаты{Name= "ЧисловойЗависящийОтСтажа",Synonim="Числовой, зависящий от стажа",Comment=""};
    }
}

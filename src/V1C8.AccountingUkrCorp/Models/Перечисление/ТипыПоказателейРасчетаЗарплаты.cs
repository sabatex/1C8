using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыПоказателейРасчетаЗарплаты", Comment = "", Synonym = "Типы показателей расчета зарплаты")]
    public enum ТипыПоказателейРасчетаЗарплаты
    {
        [Description1C8(Name = "Денежный", Comment = "", Synonym = "Денежный")]
        Денежный,
        [Description1C8(Name = "Числовой", Comment = "", Synonym = "Числовой")]
        Числовой,
        [Description1C8(Name = "ЧисловойЗависящийОтДругогоПоказателя", Comment = "", Synonym = "Числовой, зависящий от другого показателя")]
        ЧисловойЗависящийОтДругогоПоказателя,
        [Description1C8(Name = "ЧисловойЗависящийОтСтажа", Comment = "", Synonym = "Числовой, зависящий от стажа")]
        ЧисловойЗависящийОтСтажа
    }
}

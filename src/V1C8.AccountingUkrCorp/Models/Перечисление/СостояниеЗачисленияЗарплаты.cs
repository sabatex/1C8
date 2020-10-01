using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостояниеЗачисленияЗарплаты", Comment = "", Synonym = "Состояние зачисления зарплаты")]
    public enum СостояниеЗачисленияЗарплаты
    {
        [Description1C8(Name = "ОжидаетПодтверждения", Comment = "", Synonym = "Выгружен в банк")]
        ОжидаетПодтверждения,
        [Description1C8(Name = "ГотовКВыгрузке", Comment = "", Synonym = "Готов к выгрузке")]
        ГотовКВыгрузке,
        [Description1C8(Name = "ЗачисленоПолностью", Comment = "", Synonym = "Зачислено полностью")]
        ЗачисленоПолностью,
        [Description1C8(Name = "ЗачисленоСОшибками", Comment = "", Synonym = "Зачислено с ошибками (частично)")]
        ЗачисленоСОшибками,
        [Description1C8(Name = "НеЗачислено", Comment = "", Synonym = "Не зачислено (все строки - ошибки)")]
        НеЗачислено
    }
}

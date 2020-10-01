using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника", Comment = "", Synonym = "Состояние заявки на открытие лицевого счета сотрудника")]
    public enum СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника
    {
        [Description1C8(Name = "ЗаявкаНеЗаполнена", Comment = "", Synonym = "Заявка не заполнена")]
        ЗаявкаНеЗаполнена,
        [Description1C8(Name = "ОжидаетПодтверждения", Comment = "", Synonym = "Выгружен в банк")]
        ОжидаетПодтверждения,
        [Description1C8(Name = "ГотовКВыгрузке", Comment = "", Synonym = "Готов к выгрузке")]
        ГотовКВыгрузке,
        [Description1C8(Name = "ОтложеноОткрытиеЛицевогоСчета", Comment = "", Synonym = "Отложено открытие лицевого счета")]
        ОтложеноОткрытиеЛицевогоСчета,
        [Description1C8(Name = "ЛицевойСчетНеОткрыт", Comment = "", Synonym = "Лицевой счет не открыт")]
        ЛицевойСчетНеОткрыт,
        [Description1C8(Name = "ЛицевыеСчетаОткрыты", Comment = "", Synonym = "Лицевые счета открыты")]
        ЛицевыеСчетаОткрыты,
        [Description1C8(Name = "ЛицевыеСчетаОткрытыСОшибками", Comment = "", Synonym = "Лицевые счета открыты (частично)")]
        ЛицевыеСчетаОткрытыСОшибками,
        [Description1C8(Name = "ЛицевыеСчетаНеОткрыты", Comment = "", Synonym = "Лицевые счета не открыты (все строки - ошибки)")]
        ЛицевыеСчетаНеОткрыты
    }
}

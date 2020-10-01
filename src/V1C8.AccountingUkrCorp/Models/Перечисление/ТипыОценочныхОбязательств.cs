using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОценочныхОбязательств", Comment = "", Synonym = "Типы оценочных обязательств")]
    public enum ТипыОценочныхОбязательств
    {
        [Description1C8(Name = "ОценочныеОбязательстваПоВознаграждениям", Comment = "", Synonym = "Оценочные обязательства по вознаграждениям")]
        ОценочныеОбязательстваПоВознаграждениям,
        [Description1C8(Name = "ОценочныеОбязательстваПоСтраховымВзносам", Comment = "", Synonym = "Оценочные обязательства по страховым взносам")]
        ОценочныеОбязательстваПоСтраховымВзносам,
        [Description1C8(Name = "ОценочныеОбязательстваПоВзносамФССНСиПЗ", Comment = "", Synonym = "Оценочные обязательства по взносам в ФСС от НС и ПЗ")]
        ОценочныеОбязательстваПоВзносамФССНСиПЗ
    }
}

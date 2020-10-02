using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОценочныхОбязательств", Comment = "", Synonym = "Типы оценочных обязательств")]
    public class ТипыОценочныхОбязательств:EnumItem
    {
        public static readonly ТипыОценочныхОбязательств ОценочныеОбязательстваПоВознаграждениям = new ТипыОценочныхОбязательств{Name= "ОценочныеОбязательстваПоВознаграждениям",Synonym="Оценочные обязательства по вознаграждениям",Comment=""};
        public static readonly ТипыОценочныхОбязательств ОценочныеОбязательстваПоСтраховымВзносам = new ТипыОценочныхОбязательств{Name= "ОценочныеОбязательстваПоСтраховымВзносам",Synonym="Оценочные обязательства по страховым взносам",Comment=""};
        public static readonly ТипыОценочныхОбязательств ОценочныеОбязательстваПоВзносамФССНСиПЗ = new ТипыОценочныхОбязательств{Name= "ОценочныеОбязательстваПоВзносамФССНСиПЗ",Synonym="Оценочные обязательства по взносам в ФСС от НС и ПЗ",Comment=""};
    }
}

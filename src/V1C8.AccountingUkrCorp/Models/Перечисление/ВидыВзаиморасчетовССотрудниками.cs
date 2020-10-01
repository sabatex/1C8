using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыВзаиморасчетовССотрудниками", Comment = "", Synonym = "Виды взаиморасчетов с сотрудниками")]
    public enum ВидыВзаиморасчетовССотрудниками
    {
        [Description1C8(Name = "ВыплатаАванса", Comment = "", Synonym = "Выплата аванса")]
        ВыплатаАванса,
        [Description1C8(Name = "ВыплатаЗарплаты", Comment = "", Synonym = "Выплата зарплаты")]
        ВыплатаЗарплаты,
        [Description1C8(Name = "ВыплатаВМежрасчетныйПериод", Comment = "", Synonym = "Выплата в межрасчетный период")]
        ВыплатаВМежрасчетныйПериод,
        [Description1C8(Name = "ПогашениеЗадолженностиПоЗарплате", Comment = "", Synonym = "Погашение задолженности по зарплате")]
        ПогашениеЗадолженностиПоЗарплате,
        [Description1C8(Name = "ВнеочередноеПогашениеЗайма", Comment = "", Synonym = "Внеочередное погашение займа")]
        ВнеочередноеПогашениеЗайма,
        [Description1C8(Name = "ПереносЗадолженности", Comment = "", Synonym = "Перенос задолженности")]
        ПереносЗадолженности,
        [Description1C8(Name = "НачальнаяЗадолженность", Comment = "", Synonym = "Начальная задолженность")]
        НачальнаяЗадолженность
    }
}

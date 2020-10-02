using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыВзаиморасчетовССотрудниками", Comment = "", Synonym = "Виды взаиморасчетов с сотрудниками")]
    public class ВидыВзаиморасчетовССотрудниками:EnumItem
    {
        public static readonly ВидыВзаиморасчетовССотрудниками ВыплатаАванса = new ВидыВзаиморасчетовССотрудниками{Name= "ВыплатаАванса",Synonim="Выплата аванса",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками ВыплатаЗарплаты = new ВидыВзаиморасчетовССотрудниками{Name= "ВыплатаЗарплаты",Synonim="Выплата зарплаты",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками ВыплатаВМежрасчетныйПериод = new ВидыВзаиморасчетовССотрудниками{Name= "ВыплатаВМежрасчетныйПериод",Synonim="Выплата в межрасчетный период",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками ПогашениеЗадолженностиПоЗарплате = new ВидыВзаиморасчетовССотрудниками{Name= "ПогашениеЗадолженностиПоЗарплате",Synonim="Погашение задолженности по зарплате",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками ВнеочередноеПогашениеЗайма = new ВидыВзаиморасчетовССотрудниками{Name= "ВнеочередноеПогашениеЗайма",Synonim="Внеочередное погашение займа",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками ПереносЗадолженности = new ВидыВзаиморасчетовССотрудниками{Name= "ПереносЗадолженности",Synonim="Перенос задолженности",Comment=""};
        public static readonly ВидыВзаиморасчетовССотрудниками НачальнаяЗадолженность = new ВидыВзаиморасчетовССотрудниками{Name= "НачальнаяЗадолженность",Synonim="Начальная задолженность",Comment=""};
    }
}

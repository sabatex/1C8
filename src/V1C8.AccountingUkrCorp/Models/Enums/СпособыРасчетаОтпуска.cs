using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаОтпуска", Comment = "", Synonym = "Способы расчета отпуска")]
    public class СпособыРасчетаОтпуска:EnumItem
    {
        public static readonly СпособыРасчетаОтпуска ВКалендарныхДнях = new СпособыРасчетаОтпуска{Name= "ВКалендарныхДнях",Synonim="В календарных днях",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВРабочихДнях = new СпособыРасчетаОтпуска{Name= "ВРабочихДнях",Synonim="В рабочих днях",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора = new СпособыРасчетаОтпуска{Name= "ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора",Synonim="В календарных или рабочих днях в зависимости от трудового договора",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВКалендарныхДняхСПраздниками = new СпособыРасчетаОтпуска{Name= "ВКалендарныхДняхСПраздниками",Synonim="В календарных днях с праздниками",Comment=""};
    }
}

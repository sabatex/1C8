using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("SposobyRaschetaOtpuska")]
    [Description1C8(Name = "СпособыРасчетаОтпуска", Comment = "", Synonym = "Способы расчета отпуска")]
    public class СпособыРасчетаОтпуска:EnumItem
    {
        public static readonly СпособыРасчетаОтпуска ВКалендарныхДнях = new СпособыРасчетаОтпуска{Name= "ВКалендарныхДнях",Synonym="В календарных днях",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВРабочихДнях = new СпособыРасчетаОтпуска{Name= "ВРабочихДнях",Synonym="В рабочих днях",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора = new СпособыРасчетаОтпуска{Name= "ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора",Synonym="В календарных или рабочих днях в зависимости от трудового договора",Comment=""};
        public static readonly СпособыРасчетаОтпуска ВКалендарныхДняхСПраздниками = new СпособыРасчетаОтпуска{Name= "ВКалендарныхДняхСПраздниками",Synonym="В календарных днях с праздниками",Comment=""};
    }
}

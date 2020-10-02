using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДоговоровССотрудниками", Comment = "", Synonym = "Виды договоров с сотрудниками")]
    public class ВидыДоговоровССотрудниками:EnumItem
    {
        public static readonly ВидыДоговоровССотрудниками ТрудовойДоговор = new ВидыДоговоровССотрудниками{Name= "ТрудовойДоговор",Synonim="Трудовой договор",Comment=""};
        public static readonly ВидыДоговоровССотрудниками КонтрактГосслужащего = new ВидыДоговоровССотрудниками{Name= "КонтрактГосслужащего",Synonim="Контракт госслужащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками ДоговорМуниципальногоСлужащего = new ВидыДоговоровССотрудниками{Name= "ДоговорМуниципальногоСлужащего",Synonim="Договор муниципального служащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками КонтрактВоеннослужащего = new ВидыДоговоровССотрудниками{Name= "КонтрактВоеннослужащего",Synonim="Контракт военнослужащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками ВоеннослужащийПоПризыву = new ВидыДоговоровССотрудниками{Name= "ВоеннослужащийПоПризыву",Synonim="Военнослужащий по призыву",Comment=""};
    }
}

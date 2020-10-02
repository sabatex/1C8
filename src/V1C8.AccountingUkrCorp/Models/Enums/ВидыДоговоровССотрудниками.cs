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
        public static readonly ВидыДоговоровССотрудниками ТрудовойДоговор = new ВидыДоговоровССотрудниками{Name= "ТрудовойДоговор",Synonym="Трудовой договор",Comment=""};
        public static readonly ВидыДоговоровССотрудниками КонтрактГосслужащего = new ВидыДоговоровССотрудниками{Name= "КонтрактГосслужащего",Synonym="Контракт госслужащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками ДоговорМуниципальногоСлужащего = new ВидыДоговоровССотрудниками{Name= "ДоговорМуниципальногоСлужащего",Synonym="Договор муниципального служащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками КонтрактВоеннослужащего = new ВидыДоговоровССотрудниками{Name= "КонтрактВоеннослужащего",Synonym="Контракт военнослужащего",Comment=""};
        public static readonly ВидыДоговоровССотрудниками ВоеннослужащийПоПризыву = new ВидыДоговоровССотрудниками{Name= "ВоеннослужащийПоПризыву",Synonym="Военнослужащий по призыву",Comment=""};
    }
}

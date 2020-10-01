using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДоговоровССотрудниками", Comment = "", Synonym = "Виды договоров с сотрудниками")]
    public enum ВидыДоговоровССотрудниками
    {
        [Description1C8(Name = "ТрудовойДоговор", Comment = "", Synonym = "Трудовой договор")]
        ТрудовойДоговор,
        [Description1C8(Name = "КонтрактГосслужащего", Comment = "", Synonym = "Контракт госслужащего")]
        КонтрактГосслужащего,
        [Description1C8(Name = "ДоговорМуниципальногоСлужащего", Comment = "", Synonym = "Договор муниципального служащего")]
        ДоговорМуниципальногоСлужащего,
        [Description1C8(Name = "КонтрактВоеннослужащего", Comment = "", Synonym = "Контракт военнослужащего")]
        КонтрактВоеннослужащего,
        [Description1C8(Name = "ВоеннослужащийПоПризыву", Comment = "", Synonym = "Военнослужащий по призыву")]
        ВоеннослужащийПоПризыву
    }
}

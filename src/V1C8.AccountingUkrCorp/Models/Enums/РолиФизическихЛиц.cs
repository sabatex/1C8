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
    [Table("RolyFyzycheskykhLyts")]
    [Description1C8(Name = "РолиФизическихЛиц", Comment = "", Synonym = "Роли физических лиц")]
    public class РолиФизическихЛиц:EnumItem
    {
        public static readonly РолиФизическихЛиц Сотрудник = new РолиФизическихЛиц{Name= "Сотрудник",Synonym="Сотрудник",Comment=""};
        public static readonly РолиФизическихЛиц БывшийСотрудник = new РолиФизическихЛиц{Name= "БывшийСотрудник",Synonym="Бывший сотрудник",Comment=""};
        public static readonly РолиФизическихЛиц Акционер = new РолиФизическихЛиц{Name= "Акционер",Synonym="Акционер",Comment=""};
        public static readonly РолиФизическихЛиц ПрочийПолучательДоходов = new РолиФизическихЛиц{Name= "ПрочийПолучательДоходов",Synonym="Прочий получатель доходов",Comment=""};
        public static readonly РолиФизическихЛиц РаздатчикЗарплаты = new РолиФизическихЛиц{Name= "РаздатчикЗарплаты",Synonym="Раздатчик зарплаты",Comment=""};
        public static readonly РолиФизическихЛиц Кандидат = new РолиФизическихЛиц{Name= "Кандидат",Synonym="Кандидат",Comment=""};
    }
}

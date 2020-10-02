using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РолиФизическихЛиц", Comment = "", Synonym = "Роли физических лиц")]
    public class РолиФизическихЛиц:EnumItem
    {
        public static readonly РолиФизическихЛиц Сотрудник = new РолиФизическихЛиц{Name= "Сотрудник",Synonim="Сотрудник",Comment=""};
        public static readonly РолиФизическихЛиц БывшийСотрудник = new РолиФизическихЛиц{Name= "БывшийСотрудник",Synonim="Бывший сотрудник",Comment=""};
        public static readonly РолиФизическихЛиц Акционер = new РолиФизическихЛиц{Name= "Акционер",Synonim="Акционер",Comment=""};
        public static readonly РолиФизическихЛиц ПрочийПолучательДоходов = new РолиФизическихЛиц{Name= "ПрочийПолучательДоходов",Synonim="Прочий получатель доходов",Comment=""};
        public static readonly РолиФизическихЛиц РаздатчикЗарплаты = new РолиФизическихЛиц{Name= "РаздатчикЗарплаты",Synonim="Раздатчик зарплаты",Comment=""};
        public static readonly РолиФизическихЛиц Кандидат = new РолиФизическихЛиц{Name= "Кандидат",Synonim="Кандидат",Comment=""};
    }
}

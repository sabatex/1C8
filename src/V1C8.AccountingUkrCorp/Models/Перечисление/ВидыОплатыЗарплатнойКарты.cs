using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОплатыЗарплатнойКарты", Comment = "", Synonym = "Виды оплаты зарплатной карты")]
    public enum ВидыОплатыЗарплатнойКарты
    {
        [Description1C8(Name = "ОплачиваетсяПредприятием", Comment = "", Synonym = "Оплачивается предприятием")]
        ОплачиваетсяПредприятием,
        [Description1C8(Name = "ОплачиваетсяДержателем", Comment = "", Synonym = "Оплачивается держателем")]
        ОплачиваетсяДержателем,
        [Description1C8(Name = "ОплачиваетсяПредприятиемИДержателемВДолях", Comment = "", Synonym = "Оплачивается предприятием и держателем в долях")]
        ОплачиваетсяПредприятиемИДержателемВДолях
    }
}

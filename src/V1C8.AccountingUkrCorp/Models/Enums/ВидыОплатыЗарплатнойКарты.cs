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
    [Table("VydyOplatyZarplatnoiKarty")]
    [Description1C8(Name = "ВидыОплатыЗарплатнойКарты", Comment = "", Synonym = "Виды оплаты зарплатной карты")]
    public class ВидыОплатыЗарплатнойКарты:EnumItem
    {
        public static readonly ВидыОплатыЗарплатнойКарты ОплачиваетсяПредприятием = new ВидыОплатыЗарплатнойКарты{Name= "ОплачиваетсяПредприятием",Synonym="Оплачивается предприятием",Comment=""};
        public static readonly ВидыОплатыЗарплатнойКарты ОплачиваетсяДержателем = new ВидыОплатыЗарплатнойКарты{Name= "ОплачиваетсяДержателем",Synonym="Оплачивается держателем",Comment=""};
        public static readonly ВидыОплатыЗарплатнойКарты ОплачиваетсяПредприятиемИДержателемВДолях = new ВидыОплатыЗарплатнойКарты{Name= "ОплачиваетсяПредприятиемИДержателемВДолях",Synonym="Оплачивается предприятием и держателем в долях",Comment=""};
    }
}

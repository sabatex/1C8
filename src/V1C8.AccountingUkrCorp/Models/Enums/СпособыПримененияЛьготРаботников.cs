using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПримененияЛьготРаботников", Comment = "", Synonym = "Способы применения льгот работников")]
    public class СпособыПримененияЛьготРаботников:EnumItem
    {
        public static readonly СпособыПримененияЛьготРаботников Основной = new СпособыПримененияЛьготРаботников{Name= "Основной",Synonym="Основной",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаКаждогоРебенка = new СпособыПримененияЛьготРаботников{Name= "НаКаждогоРебенка",Synonym="На каждого ребенка",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаКаждогоРебенкаИнвалида = new СпособыПримененияЛьготРаботников{Name= "НаКаждогоРебенкаИнвалида",Synonym="На каждого ребенка-инвалида",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаТроихДетей = new СпособыПримененияЛьготРаботников{Name= "НаТроихДетей",Synonym="На троих и больше детей",Comment=""};
    }
}

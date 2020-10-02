using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПримененияЛьготРаботников", Comment = "", Synonym = "Способы применения льгот работников")]
    public class СпособыПримененияЛьготРаботников:EnumItem
    {
        public static readonly СпособыПримененияЛьготРаботников Основной = new СпособыПримененияЛьготРаботников{Name= "Основной",Synonim="Основной",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаКаждогоРебенка = new СпособыПримененияЛьготРаботников{Name= "НаКаждогоРебенка",Synonim="На каждого ребенка",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаКаждогоРебенкаИнвалида = new СпособыПримененияЛьготРаботников{Name= "НаКаждогоРебенкаИнвалида",Synonim="На каждого ребенка-инвалида",Comment=""};
        public static readonly СпособыПримененияЛьготРаботников НаТроихДетей = new СпособыПримененияЛьготРаботников{Name= "НаТроихДетей",Synonim="На троих и больше детей",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПримененияЛьготРаботников", Comment = "", Synonym = "Способы применения льгот работников")]
    public enum СпособыПримененияЛьготРаботников
    {
        [Description1C8(Name = "Основной", Comment = "", Synonym = "Основной")]
        Основной,
        [Description1C8(Name = "НаКаждогоРебенка", Comment = "", Synonym = "На каждого ребенка")]
        НаКаждогоРебенка,
        [Description1C8(Name = "НаКаждогоРебенкаИнвалида", Comment = "", Synonym = "На каждого ребенка-инвалида")]
        НаКаждогоРебенкаИнвалида,
        [Description1C8(Name = "НаТроихДетей", Comment = "", Synonym = "На троих и больше детей")]
        НаТроихДетей
    }
}

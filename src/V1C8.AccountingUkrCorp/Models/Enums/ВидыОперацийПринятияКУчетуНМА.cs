using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПринятияКУчетуНМА", Comment = "(Общ)", Synonym = "Виды операций принятия к учету НМА")]
    public class ВидыОперацийПринятияКУчетуНМА:EnumItem
    {
        public static readonly ВидыОперацийПринятияКУчетуНМА НематериальныеАктивы = new ВидыОперацийПринятияКУчетуНМА{Name= "НематериальныеАктивы",Synonim="Нематериальные активы",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуНМА ОбъектыСтроительства = new ВидыОперацийПринятияКУчетуНМА{Name= "ОбъектыСтроительства",Synonim="Объекты строительства",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуНМА ВводНачальныхОстатков = new ВидыОперацийПринятияКУчетуНМА{Name= "ВводНачальныхОстатков",Synonim="Ввод начальных остатков",Comment="(Общ)"};
    }
}

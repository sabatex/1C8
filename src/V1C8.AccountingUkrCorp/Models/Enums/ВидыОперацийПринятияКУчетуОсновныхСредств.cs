using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПринятияКУчетуОсновныхСредств", Comment = "(Общ)", Synonym = "Виды операций принятия к учету основных средств")]
    public class ВидыОперацийПринятияКУчетуОсновныхСредств:EnumItem
    {
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств Оборудование = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "Оборудование",Synonim="Оборудование",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств ОбъектыСтроительства = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "ОбъектыСтроительства",Synonim="Объекты строительства",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств ПоРезультатамИнвентаризации = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "ПоРезультатамИнвентаризации",Synonim="По результатам инвентаризации",Comment="(Общ)"};
    }
}

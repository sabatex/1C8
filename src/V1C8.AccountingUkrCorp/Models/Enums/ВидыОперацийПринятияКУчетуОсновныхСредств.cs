using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПринятияКУчетуОсновныхСредств", Comment = "(Общ)", Synonym = "Виды операций принятия к учету основных средств")]
    public class ВидыОперацийПринятияКУчетуОсновныхСредств:EnumItem
    {
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств Оборудование = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "Оборудование",Synonym="Оборудование",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств ОбъектыСтроительства = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "ОбъектыСтроительства",Synonym="Объекты строительства",Comment="(Общ)"};
        public static readonly ВидыОперацийПринятияКУчетуОсновныхСредств ПоРезультатамИнвентаризации = new ВидыОперацийПринятияКУчетуОсновныхСредств{Name= "ПоРезультатамИнвентаризации",Synonym="По результатам инвентаризации",Comment="(Общ)"};
    }
}

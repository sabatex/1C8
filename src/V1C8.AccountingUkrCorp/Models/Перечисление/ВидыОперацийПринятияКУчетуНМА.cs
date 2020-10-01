using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПринятияКУчетуНМА", Comment = "(Общ)", Synonym = "Виды операций принятия к учету НМА")]
    public enum ВидыОперацийПринятияКУчетуНМА
    {
        [Description1C8(Name = "НематериальныеАктивы", Comment = "(Общ)", Synonym = "Нематериальные активы")]
        НематериальныеАктивы,
        [Description1C8(Name = "ОбъектыСтроительства", Comment = "(Общ)", Synonym = "Объекты строительства")]
        ОбъектыСтроительства,
        [Description1C8(Name = "ВводНачальныхОстатков", Comment = "(Общ)", Synonym = "Ввод начальных остатков")]
        ВводНачальныхОстатков
    }
}

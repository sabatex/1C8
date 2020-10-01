using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРасчетовПоСредствамФСС", Comment = "", Synonym = "Виды расчетов по средствам ФСС")]
    public enum ВидыРасчетовПоСредствамФСС
    {
        [Description1C8(Name = "РасходыПоСтрахованию", Comment = "", Synonym = "Расходы по страхованию")]
        РасходыПоСтрахованию,
        [Description1C8(Name = "ПолученоИзФонда", Comment = "", Synonym = "Получено из фонда")]
        ПолученоИзФонда,
        [Description1C8(Name = "НеПринято", Comment = "", Synonym = "Не принято к зачету")]
        НеПринято
    }
}

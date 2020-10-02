using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРасчетовПоСредствамФСС", Comment = "", Synonym = "Виды расчетов по средствам ФСС")]
    public class ВидыРасчетовПоСредствамФСС:EnumItem
    {
        public static readonly ВидыРасчетовПоСредствамФСС РасходыПоСтрахованию = new ВидыРасчетовПоСредствамФСС{Name= "РасходыПоСтрахованию",Synonym="Расходы по страхованию",Comment=""};
        public static readonly ВидыРасчетовПоСредствамФСС ПолученоИзФонда = new ВидыРасчетовПоСредствамФСС{Name= "ПолученоИзФонда",Synonym="Получено из фонда",Comment=""};
        public static readonly ВидыРасчетовПоСредствамФСС НеПринято = new ВидыРасчетовПоСредствамФСС{Name= "НеПринято",Synonym="Не принято к зачету",Comment=""};
    }
}

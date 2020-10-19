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
    [Table("VydyRaschetovPoDohovoram")]
    [Description1C8(Name = "ВидыРасчетовПоДоговорам", Comment = "", Synonym = "Виды расчетов по договорам")]
    public class ВидыРасчетовПоДоговорам:EnumItem
    {
        public static readonly ВидыРасчетовПоДоговорам РасчетыВВалютеРегламентированногоУчета = new ВидыРасчетовПоДоговорам{Name= "РасчетыВВалютеРегламентированногоУчета",Synonym="Расчеты в валюте регламентированного учета",Comment=""};
        public static readonly ВидыРасчетовПоДоговорам РасчетыВИностраннойВалюте = new ВидыРасчетовПоДоговорам{Name= "РасчетыВИностраннойВалюте",Synonym="Расчеты в иностранной валюте",Comment=""};
    }
}

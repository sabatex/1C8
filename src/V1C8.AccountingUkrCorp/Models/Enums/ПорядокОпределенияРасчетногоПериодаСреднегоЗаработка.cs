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
    [Table("PoriadokOpredelenyiaRaschetnohoPeryodaSrednehoZarabotka")]
    [Description1C8(Name = "ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка", Comment = "", Synonym = "Порядок определения расчетного периода среднего заработка")]
    public class ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка:EnumItem
    {
        public static readonly ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка ПоТрудовомуЗаконодательству = new ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка{Name= "ПоТрудовомуЗаконодательству",Synonym="В соответствии с законодательством",Comment=""};
        public static readonly ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка ПоКолдоговору = new ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка{Name= "ПоКолдоговору",Synonym="В соответствии с коллективным договором",Comment=""};
    }
}

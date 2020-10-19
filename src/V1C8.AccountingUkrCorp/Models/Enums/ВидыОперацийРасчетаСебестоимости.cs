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
    [Table("VydyOperatsyiRaschetaSebestoymosty")]
    [Description1C8(Name = "ВидыОперацийРасчетаСебестоимости", Comment = "", Synonym = "Виды операций расчета себестоимости")]
    public class ВидыОперацийРасчетаСебестоимости:EnumItem
    {
        public static readonly ВидыОперацийРасчетаСебестоимости РасходыНаПроизводствоПродукцииИУслуг = new ВидыОперацийРасчетаСебестоимости{Name= "РасходыНаПроизводствоПродукцииИУслуг",Synonym="Расходы на производство продукции и услуг",Comment=""};
        public static readonly ВидыОперацийРасчетаСебестоимости УслугиБезИспользованияПлановыхЦен = new ВидыОперацийРасчетаСебестоимости{Name= "УслугиБезИспользованияПлановыхЦен",Synonym="Услуги без использования плановых цен",Comment=""};
        public static readonly ВидыОперацийРасчетаСебестоимости ВыпускПродукцииИУслуг = new ВидыОперацийРасчетаСебестоимости{Name= "ВыпускПродукцииИУслуг",Synonym="Выпуск продукции и услуг",Comment=""};
    }
}

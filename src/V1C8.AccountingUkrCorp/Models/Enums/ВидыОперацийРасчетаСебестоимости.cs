using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРасчетаСебестоимости", Comment = "", Synonym = "Виды операций расчета себестоимости")]
    public class ВидыОперацийРасчетаСебестоимости:EnumItem
    {
        public static readonly ВидыОперацийРасчетаСебестоимости РасходыНаПроизводствоПродукцииИУслуг = new ВидыОперацийРасчетаСебестоимости{Name= "РасходыНаПроизводствоПродукцииИУслуг",Synonim="Расходы на производство продукции и услуг",Comment=""};
        public static readonly ВидыОперацийРасчетаСебестоимости УслугиБезИспользованияПлановыхЦен = new ВидыОперацийРасчетаСебестоимости{Name= "УслугиБезИспользованияПлановыхЦен",Synonim="Услуги без использования плановых цен",Comment=""};
        public static readonly ВидыОперацийРасчетаСебестоимости ВыпускПродукцииИУслуг = new ВидыОперацийРасчетаСебестоимости{Name= "ВыпускПродукцииИУслуг",Synonim="Выпуск продукции и услуг",Comment=""};
    }
}

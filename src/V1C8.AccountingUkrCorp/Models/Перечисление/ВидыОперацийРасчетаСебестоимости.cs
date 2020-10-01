using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРасчетаСебестоимости", Comment = "", Synonym = "Виды операций расчета себестоимости")]
    public enum ВидыОперацийРасчетаСебестоимости
    {
        [Description1C8(Name = "РасходыНаПроизводствоПродукцииИУслуг", Comment = "", Synonym = "Расходы на производство продукции и услуг")]
        РасходыНаПроизводствоПродукцииИУслуг,
        [Description1C8(Name = "УслугиБезИспользованияПлановыхЦен", Comment = "", Synonym = "Услуги без использования плановых цен")]
        УслугиБезИспользованияПлановыхЦен,
        [Description1C8(Name = "ВыпускПродукцииИУслуг", Comment = "", Synonym = "Выпуск продукции и услуг")]
        ВыпускПродукцииИУслуг
    }
}

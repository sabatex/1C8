using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРасчетаКосвенныхРасходов", Comment = "", Synonym = "Виды операций расчета косвенных расходов")]
    public enum ВидыОперацийРасчетаКосвенныхРасходов
    {
        [Description1C8(Name = "РаспределениеОбщепроизводственныхРасходов", Comment = "", Synonym = "Распределение общепроизводственных расходов")]
        РаспределениеОбщепроизводственныхРасходов,
        [Description1C8(Name = "РаспределениеОбщехозяйственныхРасходов", Comment = "", Synonym = "Распределение общехозяйственных расходов")]
        РаспределениеОбщехозяйственныхРасходов,
        [Description1C8(Name = "УслугиБезИспользованияПлановыхЦен", Comment = "", Synonym = "Услуги без использования плановых цен")]
        УслугиБезИспользованияПлановыхЦен,
        [Description1C8(Name = "ВыпускПродукцииИУслуг", Comment = "", Synonym = "Выпуск продукции и услуг")]
        ВыпускПродукцииИУслуг
    }
}

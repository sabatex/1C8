using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг", Comment = "", Synonym = "Порядок распределения расходов на оказание услуг производственными подразделениями друг другу")]
    public enum ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг
    {
        [Description1C8(Name = "ПоПлановымЦенам", Comment = "", Synonym = "По плановой себестоимости выпуска")]
        ПоПлановымЦенам,
        [Description1C8(Name = "ПоОбъемуВыпуска", Comment = "", Synonym = "По объему выпуска")]
        ПоОбъемуВыпуска,
        [Description1C8(Name = "ПоПлановымЦенамИОбъемуВыпуска", Comment = "", Synonym = "По плановой себестоимости и по объему выпуска")]
        ПоПлановымЦенамИОбъемуВыпуска
    }
}

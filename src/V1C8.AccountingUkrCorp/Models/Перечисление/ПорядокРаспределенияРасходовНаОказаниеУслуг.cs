using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРаспределенияРасходовНаОказаниеУслуг", Comment = "", Synonym = "Порядок распределения расходов на оказание услуг сторонним организациям")]
    public enum ПорядокРаспределенияРасходовНаОказаниеУслуг
    {
        [Description1C8(Name = "ПоПлановымЦенам", Comment = "", Synonym = "По плановой себестоимости выпуска")]
        ПоПлановымЦенам,
        [Description1C8(Name = "ПоВыручке", Comment = "", Synonym = "По выручке")]
        ПоВыручке,
        [Description1C8(Name = "ПоПлановымЦенамИВыручке", Comment = "", Synonym = "По плановой себестоимости выпуска и выручке")]
        ПоПлановымЦенамИВыручке
    }
}

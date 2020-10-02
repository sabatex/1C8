using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг", Comment = "", Synonym = "Порядок распределения расходов на оказание услуг производственными подразделениями друг другу")]
    public class ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг:EnumItem
    {
        public static readonly ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг ПоПлановымЦенам = new ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг{Name= "ПоПлановымЦенам",Synonym="По плановой себестоимости выпуска",Comment=""};
        public static readonly ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг ПоОбъемуВыпуска = new ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг{Name= "ПоОбъемуВыпуска",Synonym="По объему выпуска",Comment=""};
        public static readonly ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг ПоПлановымЦенамИОбъемуВыпуска = new ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг{Name= "ПоПлановымЦенамИОбъемуВыпуска",Synonym="По плановой себестоимости и по объему выпуска",Comment=""};
    }
}

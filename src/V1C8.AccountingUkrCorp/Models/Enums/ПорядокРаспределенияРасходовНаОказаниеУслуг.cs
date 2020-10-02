using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРаспределенияРасходовНаОказаниеУслуг", Comment = "", Synonym = "Порядок распределения расходов на оказание услуг сторонним организациям")]
    public class ПорядокРаспределенияРасходовНаОказаниеУслуг:EnumItem
    {
        public static readonly ПорядокРаспределенияРасходовНаОказаниеУслуг ПоПлановымЦенам = new ПорядокРаспределенияРасходовНаОказаниеУслуг{Name= "ПоПлановымЦенам",Synonim="По плановой себестоимости выпуска",Comment=""};
        public static readonly ПорядокРаспределенияРасходовНаОказаниеУслуг ПоВыручке = new ПорядокРаспределенияРасходовНаОказаниеУслуг{Name= "ПоВыручке",Synonim="По выручке",Comment=""};
        public static readonly ПорядокРаспределенияРасходовНаОказаниеУслуг ПоПлановымЦенамИВыручке = new ПорядокРаспределенияРасходовНаОказаниеУслуг{Name= "ПоПлановымЦенамИВыручке",Synonim="По плановой себестоимости выпуска и выручке",Comment=""};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРаспределенияКосвенныхРасходов", Comment = "(Общ)", Synonym = "Способы распределения косвенных расходов")]
    public enum СпособыРаспределенияКосвенныхРасходов
    {
        [Description1C8(Name = "ОбъемВыпуска", Comment = "(Общ)", Synonym = "Объем выпуска")]
        ОбъемВыпуска,
        [Description1C8(Name = "ПлановаяСебестоимость", Comment = "(Общ)", Synonym = "Плановая себестоимость выпуска")]
        ПлановаяСебестоимость,
        [Description1C8(Name = "ОплатаТруда", Comment = "(Общ)", Synonym = "Оплата труда")]
        ОплатаТруда,
        [Description1C8(Name = "МатериальныеЗатраты", Comment = "(Общ)", Synonym = "Материальные затраты")]
        МатериальныеЗатраты,
        [Description1C8(Name = "ПрямыеЗатраты", Comment = "(Общ)", Synonym = "Прямые затраты")]
        ПрямыеЗатраты,
        [Description1C8(Name = "ОтдельныеСтатьиПрямыхЗатрат", Comment = "(Общ)", Synonym = "Отдельные статьи прямых затрат")]
        ОтдельныеСтатьиПрямыхЗатрат,
        [Description1C8(Name = "НеРаспределяется", Comment = "", Synonym = "Не распределяется")]
        НеРаспределяется
    }
}

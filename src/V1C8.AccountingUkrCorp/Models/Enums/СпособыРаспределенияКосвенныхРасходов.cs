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
    [Table("SposobyRaspredelenyiaKosvennykhRaskhodov")]
    [Description1C8(Name = "СпособыРаспределенияКосвенныхРасходов", Comment = "(Общ)", Synonym = "Способы распределения косвенных расходов")]
    public class СпособыРаспределенияКосвенныхРасходов:EnumItem
    {
        public static readonly СпособыРаспределенияКосвенныхРасходов ОбъемВыпуска = new СпособыРаспределенияКосвенныхРасходов{Name= "ОбъемВыпуска",Synonym="Объем выпуска",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов ПлановаяСебестоимость = new СпособыРаспределенияКосвенныхРасходов{Name= "ПлановаяСебестоимость",Synonym="Плановая себестоимость выпуска",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов ОплатаТруда = new СпособыРаспределенияКосвенныхРасходов{Name= "ОплатаТруда",Synonym="Оплата труда",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов МатериальныеЗатраты = new СпособыРаспределенияКосвенныхРасходов{Name= "МатериальныеЗатраты",Synonym="Материальные затраты",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов ПрямыеЗатраты = new СпособыРаспределенияКосвенныхРасходов{Name= "ПрямыеЗатраты",Synonym="Прямые затраты",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов ОтдельныеСтатьиПрямыхЗатрат = new СпособыРаспределенияКосвенныхРасходов{Name= "ОтдельныеСтатьиПрямыхЗатрат",Synonym="Отдельные статьи прямых затрат",Comment="(Общ)"};
        public static readonly СпособыРаспределенияКосвенныхРасходов НеРаспределяется = new СпособыРаспределенияКосвенныхРасходов{Name= "НеРаспределяется",Synonym="Не распределяется",Comment=""};
    }
}

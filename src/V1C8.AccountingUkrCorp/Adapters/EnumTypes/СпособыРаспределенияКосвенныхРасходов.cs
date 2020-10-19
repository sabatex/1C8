using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРаспределенияКосвенныхРасходов:EnumBase
    {
        public СпособыРаспределенияКосвенныхРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбъемВыпуска => GetProperty<EnumItem>("ОбъемВыпуска");
        public EnumItem ПлановаяСебестоимость => GetProperty<EnumItem>("ПлановаяСебестоимость");
        public EnumItem ОплатаТруда => GetProperty<EnumItem>("ОплатаТруда");
        public EnumItem МатериальныеЗатраты => GetProperty<EnumItem>("МатериальныеЗатраты");
        public EnumItem ПрямыеЗатраты => GetProperty<EnumItem>("ПрямыеЗатраты");
        public EnumItem ОтдельныеСтатьиПрямыхЗатрат => GetProperty<EnumItem>("ОтдельныеСтатьиПрямыхЗатрат");
        public EnumItem НеРаспределяется => GetProperty<EnumItem>("НеРаспределяется");
    }
}

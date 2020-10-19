using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРаспределенияКосвенныхРасходов:V1C8COMObject
    {
        public СпособыРаспределенияКосвенныхРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбъемВыпуска => GetProperty<EnumItemBase>("ОбъемВыпуска");
        public EnumItemBase ПлановаяСебестоимость => GetProperty<EnumItemBase>("ПлановаяСебестоимость");
        public EnumItemBase ОплатаТруда => GetProperty<EnumItemBase>("ОплатаТруда");
        public EnumItemBase МатериальныеЗатраты => GetProperty<EnumItemBase>("МатериальныеЗатраты");
        public EnumItemBase ПрямыеЗатраты => GetProperty<EnumItemBase>("ПрямыеЗатраты");
        public EnumItemBase ОтдельныеСтатьиПрямыхЗатрат => GetProperty<EnumItemBase>("ОтдельныеСтатьиПрямыхЗатрат");
        public EnumItemBase НеРаспределяется => GetProperty<EnumItemBase>("НеРаспределяется");
    }
}

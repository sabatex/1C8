using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРаспределенияКосвенныхРасходов:V1C8COMObject
    {
        public СпособыРаспределенияКосвенныхРасходов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбъемВыпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ПлановаяСебестоимость => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаТруда => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальныеЗатраты => GetProperty<EnumItemBase>();
        public EnumItemBase ПрямыеЗатраты => GetProperty<EnumItemBase>();
        public EnumItemBase ОтдельныеСтатьиПрямыхЗатрат => GetProperty<EnumItemBase>();
        public EnumItemBase НеРаспределяется => GetProperty<EnumItemBase>();
    }
}

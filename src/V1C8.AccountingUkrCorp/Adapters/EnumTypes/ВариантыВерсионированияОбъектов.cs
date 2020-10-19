using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыВерсионированияОбъектов:V1C8COMObject
    {
        public ВариантыВерсионированияОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВерсионироватьПриЗаписи => GetProperty<EnumItemBase>("ВерсионироватьПриЗаписи");
        public EnumItemBase ВерсионироватьПриПроведении => GetProperty<EnumItemBase>("ВерсионироватьПриПроведении");
        public EnumItemBase ВерсионироватьПриСтарте => GetProperty<EnumItemBase>("ВерсионироватьПриСтарте");
        public EnumItemBase НеВерсионировать => GetProperty<EnumItemBase>("НеВерсионировать");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыВерсионированияОбъектов:V1C8COMObject
    {
        public ВариантыВерсионированияОбъектов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВерсионироватьПриЗаписи => GetProperty<EnumItemBase>();
        public EnumItemBase ВерсионироватьПриПроведении => GetProperty<EnumItemBase>();
        public EnumItemBase ВерсионироватьПриСтарте => GetProperty<EnumItemBase>();
        public EnumItemBase НеВерсионировать => GetProperty<EnumItemBase>();
    }
}

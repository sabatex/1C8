using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыВерсионированияОбъектов:EnumBase
    {
        public ВариантыВерсионированияОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВерсионироватьПриЗаписи => GetProperty<EnumItem>("ВерсионироватьПриЗаписи");
        public EnumItem ВерсионироватьПриПроведении => GetProperty<EnumItem>("ВерсионироватьПриПроведении");
        public EnumItem ВерсионироватьПриСтарте => GetProperty<EnumItem>("ВерсионироватьПриСтарте");
        public EnumItem НеВерсионировать => GetProperty<EnumItem>("НеВерсионировать");
    }
}

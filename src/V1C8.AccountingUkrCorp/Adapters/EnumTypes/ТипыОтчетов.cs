using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОтчетов:EnumBase
    {
        public ТипыОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Внутренний => GetProperty<EnumItem>("Внутренний");
        public EnumItem Дополнительный => GetProperty<EnumItem>("Дополнительный");
        public EnumItem Расширение => GetProperty<EnumItem>("Расширение");
        public EnumItem Внешний => GetProperty<EnumItem>("Внешний");
        public EnumItem УдалитьОтчет => GetProperty<EnumItem>("УдалитьОтчет");
        public EnumItem УдалитьПользовательский => GetProperty<EnumItem>("УдалитьПользовательский");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодичностиРасписанийРассылокОтчетов:EnumBase
    {
        public ПериодичностиРасписанийРассылокОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Ежедневно => GetProperty<EnumItem>("Ежедневно");
        public EnumItem Еженедельно => GetProperty<EnumItem>("Еженедельно");
        public EnumItem Ежемесячно => GetProperty<EnumItem>("Ежемесячно");
        public EnumItem Произвольное => GetProperty<EnumItem>("Произвольное");
    }
}

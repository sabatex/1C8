using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодичностиРасписанийРассылокОтчетов:V1C8COMObject
    {
        public ПериодичностиРасписанийРассылокОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Ежедневно => GetProperty<EnumItemBase>("Ежедневно");
        public EnumItemBase Еженедельно => GetProperty<EnumItemBase>("Еженедельно");
        public EnumItemBase Ежемесячно => GetProperty<EnumItemBase>("Ежемесячно");
        public EnumItemBase Произвольное => GetProperty<EnumItemBase>("Произвольное");
    }
}

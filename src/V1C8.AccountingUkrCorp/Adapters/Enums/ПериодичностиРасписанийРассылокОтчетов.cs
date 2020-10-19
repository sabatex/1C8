using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПериодичностиРасписанийРассылокОтчетов:V1C8COMObject
    {
        public ПериодичностиРасписанийРассылокОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Ежедневно => GetProperty<EnumItemBase>();
        public EnumItemBase Еженедельно => GetProperty<EnumItemBase>();
        public EnumItemBase Ежемесячно => GetProperty<EnumItemBase>();
        public EnumItemBase Произвольное => GetProperty<EnumItemBase>();
    }
}

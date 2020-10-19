using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СообщенияДляРегОтчетов:V1C8COMObject
    {
        public СообщенияДляРегОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СдачаОтчета => GetProperty<EnumItemBase>();
        public EnumItemBase УплатаНалога => GetProperty<EnumItemBase>();
    }
}

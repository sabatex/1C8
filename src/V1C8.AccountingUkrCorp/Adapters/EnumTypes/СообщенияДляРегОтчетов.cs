using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СообщенияДляРегОтчетов:EnumBase
    {
        public СообщенияДляРегОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СдачаОтчета => GetProperty<EnumItem>("СдачаОтчета");
        public EnumItem УплатаНалога => GetProperty<EnumItem>("УплатаНалога");
    }
}

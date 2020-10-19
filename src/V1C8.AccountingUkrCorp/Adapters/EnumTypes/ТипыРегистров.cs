using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыРегистров:EnumBase
    {
        public ТипыРегистров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem РегистрНакопления => GetProperty<EnumItem>("РегистрНакопления");
        public EnumItem РегистрСведений => GetProperty<EnumItem>("РегистрСведений");
    }
}

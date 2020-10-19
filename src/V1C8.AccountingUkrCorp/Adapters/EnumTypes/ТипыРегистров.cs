using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыРегистров:V1C8COMObject
    {
        public ТипыРегистров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РегистрНакопления => GetProperty<EnumItemBase>("РегистрНакопления");
        public EnumItemBase РегистрСведений => GetProperty<EnumItemBase>("РегистрСведений");
    }
}

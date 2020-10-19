using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияОС:V1C8COMObject
    {
        public СостоянияОС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВведеноВЭксплуатацию => GetProperty<EnumItemBase>("ВведеноВЭксплуатацию");
        public EnumItemBase СнятоСУчета => GetProperty<EnumItemBase>("СнятоСУчета");
    }
}

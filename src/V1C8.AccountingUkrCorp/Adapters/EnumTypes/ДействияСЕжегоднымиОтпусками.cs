using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСЕжегоднымиОтпусками:V1C8COMObject
    {
        public ДействияСЕжегоднымиОтпусками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Утвердить => GetProperty<EnumItemBase>("Утвердить");
        public EnumItemBase Отменить => GetProperty<EnumItemBase>("Отменить");
    }
}

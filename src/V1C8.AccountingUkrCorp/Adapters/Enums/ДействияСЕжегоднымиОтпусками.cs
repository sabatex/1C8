using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДействияСЕжегоднымиОтпусками:V1C8COMObject
    {
        public ДействияСЕжегоднымиОтпусками(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Утвердить => GetProperty<EnumItemBase>();
        public EnumItemBase Отменить => GetProperty<EnumItemBase>();
    }
}

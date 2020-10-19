using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСЕжегоднымиОтпусками:EnumBase
    {
        public ДействияСЕжегоднымиОтпусками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Утвердить => GetProperty<EnumItem>("Утвердить");
        public EnumItem Отменить => GetProperty<EnumItem>("Отменить");
    }
}

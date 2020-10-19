using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОтчетности:V1C8COMObject
    {
        public ВидыОтчетности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РегламентированнаяОтчетность => GetProperty<EnumItemBase>();
        public EnumItemBase ОтчетностьПоМСФО => GetProperty<EnumItemBase>();
    }
}

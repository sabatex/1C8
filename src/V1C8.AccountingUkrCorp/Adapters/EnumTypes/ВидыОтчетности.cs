using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОтчетности:V1C8COMObject
    {
        public ВидыОтчетности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РегламентированнаяОтчетность => GetProperty<EnumItemBase>("РегламентированнаяОтчетность");
        public EnumItemBase ОтчетностьПоМСФО => GetProperty<EnumItemBase>("ОтчетностьПоМСФО");
    }
}

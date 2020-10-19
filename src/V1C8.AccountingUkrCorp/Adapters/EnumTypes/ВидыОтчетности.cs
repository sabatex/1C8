using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОтчетности:EnumBase
    {
        public ВидыОтчетности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem РегламентированнаяОтчетность => GetProperty<EnumItem>("РегламентированнаяОтчетность");
        public EnumItem ОтчетностьПоМСФО => GetProperty<EnumItem>("ОтчетностьПоМСФО");
    }
}

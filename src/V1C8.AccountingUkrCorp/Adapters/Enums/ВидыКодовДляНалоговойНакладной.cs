using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыКодовДляНалоговойНакладной:V1C8COMObject
    {
        public ВидыКодовДляНалоговойНакладной(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КодТовара => GetProperty<EnumItemBase>();
        public EnumItemBase КодТовараИмпортированного => GetProperty<EnumItemBase>();
        public EnumItemBase КодУслуги => GetProperty<EnumItemBase>();
    }
}

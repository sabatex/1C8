using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКодовДляНалоговойНакладной:V1C8COMObject
    {
        public ВидыКодовДляНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КодТовара => GetProperty<EnumItemBase>("КодТовара");
        public EnumItemBase КодТовараИмпортированного => GetProperty<EnumItemBase>("КодТовараИмпортированного");
        public EnumItemBase КодУслуги => GetProperty<EnumItemBase>("КодУслуги");
    }
}

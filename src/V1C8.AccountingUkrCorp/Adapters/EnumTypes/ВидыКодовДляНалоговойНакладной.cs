using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКодовДляНалоговойНакладной:EnumBase
    {
        public ВидыКодовДляНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem КодТовара => GetProperty<EnumItem>("КодТовара");
        public EnumItem КодТовараИмпортированного => GetProperty<EnumItem>("КодТовараИмпортированного");
        public EnumItem КодУслуги => GetProperty<EnumItem>("КодУслуги");
    }
}

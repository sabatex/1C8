using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСФайламиПоДвойномуЩелчку:EnumBase
    {
        public ДействияСФайламиПоДвойномуЩелчку(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОткрыватьФайл => GetProperty<EnumItem>("ОткрыватьФайл");
        public EnumItem ОткрыватьКарточку => GetProperty<EnumItem>("ОткрыватьКарточку");
    }
}

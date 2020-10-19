using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСФайламиПоДвойномуЩелчку:V1C8COMObject
    {
        public ДействияСФайламиПоДвойномуЩелчку(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОткрыватьФайл => GetProperty<EnumItemBase>("ОткрыватьФайл");
        public EnumItemBase ОткрыватьКарточку => GetProperty<EnumItemBase>("ОткрыватьКарточку");
    }
}

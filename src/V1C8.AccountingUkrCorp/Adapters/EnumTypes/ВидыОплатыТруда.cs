using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОплатыТруда:V1C8COMObject
    {
        public ВидыОплатыТруда(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФОТ => GetProperty<EnumItemBase>("ФОТ");
        public EnumItemBase НеФОТ => GetProperty<EnumItemBase>("НеФОТ");
    }
}

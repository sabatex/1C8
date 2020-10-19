using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОплатыТруда:V1C8COMObject
    {
        public ВидыОплатыТруда(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase НеФОТ => GetProperty<EnumItemBase>();
    }
}

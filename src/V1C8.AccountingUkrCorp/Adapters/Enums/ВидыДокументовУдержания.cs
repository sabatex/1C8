using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДокументовУдержания:V1C8COMObject
    {
        public ВидыДокументовУдержания(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>();
    }
}

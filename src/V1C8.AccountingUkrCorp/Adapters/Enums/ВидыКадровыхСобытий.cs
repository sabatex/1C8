using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыКадровыхСобытий:V1C8COMObject
    {
        public ВидыКадровыхСобытий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прием => GetProperty<EnumItemBase>();
        public EnumItemBase Перемещение => GetProperty<EnumItemBase>();
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>();
        public EnumItemBase НачальныеДанные => GetProperty<EnumItemBase>();
    }
}

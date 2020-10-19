using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКадровыхСобытий:V1C8COMObject
    {
        public ВидыКадровыхСобытий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прием => GetProperty<EnumItemBase>("Прием");
        public EnumItemBase Перемещение => GetProperty<EnumItemBase>("Перемещение");
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>("Увольнение");
        public EnumItemBase НачальныеДанные => GetProperty<EnumItemBase>("НачальныеДанные");
    }
}

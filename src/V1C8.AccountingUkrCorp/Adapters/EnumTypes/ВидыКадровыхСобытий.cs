using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКадровыхСобытий:EnumBase
    {
        public ВидыКадровыхСобытий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Прием => GetProperty<EnumItem>("Прием");
        public EnumItem Перемещение => GetProperty<EnumItem>("Перемещение");
        public EnumItem Увольнение => GetProperty<EnumItem>("Увольнение");
        public EnumItem НачальныеДанные => GetProperty<EnumItem>("НачальныеДанные");
    }
}

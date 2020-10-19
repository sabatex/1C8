using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыИспользованияВнешнихКомпонент:V1C8COMObject
    {
        public ВариантыИспользованияВнешнихКомпонент(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Используется => GetProperty<EnumItemBase>("Используется");
        public EnumItemBase Отключена => GetProperty<EnumItemBase>("Отключена");
    }
}

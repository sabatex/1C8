using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРабочихГрафиков:V1C8COMObject
    {
        public ВидыРабочихГрафиков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Пятидневка => GetProperty<EnumItemBase>("Пятидневка");
        public EnumItemBase Шестидневка => GetProperty<EnumItemBase>("Шестидневка");
        public EnumItemBase Сменный => GetProperty<EnumItemBase>("Сменный");
    }
}

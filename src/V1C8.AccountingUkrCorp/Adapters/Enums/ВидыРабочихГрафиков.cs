using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыРабочихГрафиков:V1C8COMObject
    {
        public ВидыРабочихГрафиков(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Пятидневка => GetProperty<EnumItemBase>();
        public EnumItemBase Шестидневка => GetProperty<EnumItemBase>();
        public EnumItemBase Сменный => GetProperty<EnumItemBase>();
    }
}

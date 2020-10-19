using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ЦветностиИзображения:V1C8COMObject
    {
        public ЦветностиИзображения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Монохромное => GetProperty<EnumItemBase>();
        public EnumItemBase ГрадацииСерого => GetProperty<EnumItemBase>();
        public EnumItemBase Цветное => GetProperty<EnumItemBase>();
    }
}

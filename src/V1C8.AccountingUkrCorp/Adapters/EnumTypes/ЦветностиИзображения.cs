using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЦветностиИзображения:V1C8COMObject
    {
        public ЦветностиИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Монохромное => GetProperty<EnumItemBase>("Монохромное");
        public EnumItemBase ГрадацииСерого => GetProperty<EnumItemBase>("ГрадацииСерого");
        public EnumItemBase Цветное => GetProperty<EnumItemBase>("Цветное");
    }
}

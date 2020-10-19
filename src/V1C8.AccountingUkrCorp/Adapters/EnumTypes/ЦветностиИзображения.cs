using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЦветностиИзображения:EnumBase
    {
        public ЦветностиИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Монохромное => GetProperty<EnumItem>("Монохромное");
        public EnumItem ГрадацииСерого => GetProperty<EnumItem>("ГрадацииСерого");
        public EnumItem Цветное => GetProperty<EnumItem>("Цветное");
    }
}

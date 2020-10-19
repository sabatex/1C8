using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныИзмененияСостояния:EnumBase
    {
        public ПричиныИзмененияСостояния(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПриемНаРаботу => GetProperty<EnumItem>("ПриемНаРаботу");
        public EnumItem Перемещение => GetProperty<EnumItem>("Перемещение");
        public EnumItem Увольнение => GetProperty<EnumItem>("Увольнение");
    }
}

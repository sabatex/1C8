using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УровниПроизводительности:EnumBase
    {
        public УровниПроизводительности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Идеально => GetProperty<EnumItem>("Идеально");
        public EnumItem Отлично => GetProperty<EnumItem>("Отлично");
        public EnumItem Хорошо => GetProperty<EnumItem>("Хорошо");
        public EnumItem Удовлетворительно => GetProperty<EnumItem>("Удовлетворительно");
        public EnumItem Плохо => GetProperty<EnumItem>("Плохо");
    }
}

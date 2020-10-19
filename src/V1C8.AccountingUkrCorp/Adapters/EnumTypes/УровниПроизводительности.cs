using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УровниПроизводительности:V1C8COMObject
    {
        public УровниПроизводительности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Идеально => GetProperty<EnumItemBase>("Идеально");
        public EnumItemBase Отлично => GetProperty<EnumItemBase>("Отлично");
        public EnumItemBase Хорошо => GetProperty<EnumItemBase>("Хорошо");
        public EnumItemBase Удовлетворительно => GetProperty<EnumItemBase>("Удовлетворительно");
        public EnumItemBase Плохо => GetProperty<EnumItemBase>("Плохо");
    }
}

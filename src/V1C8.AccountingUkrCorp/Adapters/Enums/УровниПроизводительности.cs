using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УровниПроизводительности:V1C8COMObject
    {
        public УровниПроизводительности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Идеально => GetProperty<EnumItemBase>();
        public EnumItemBase Отлично => GetProperty<EnumItemBase>();
        public EnumItemBase Хорошо => GetProperty<EnumItemBase>();
        public EnumItemBase Удовлетворительно => GetProperty<EnumItemBase>();
        public EnumItemBase Плохо => GetProperty<EnumItemBase>();
    }
}

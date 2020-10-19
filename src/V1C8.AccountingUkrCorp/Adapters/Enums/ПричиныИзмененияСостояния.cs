using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПричиныИзмененияСостояния:V1C8COMObject
    {
        public ПричиныИзмененияСостояния(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПриемНаРаботу => GetProperty<EnumItemBase>();
        public EnumItemBase Перемещение => GetProperty<EnumItemBase>();
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>();
    }
}

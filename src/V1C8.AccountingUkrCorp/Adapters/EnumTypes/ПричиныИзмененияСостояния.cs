using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныИзмененияСостояния:V1C8COMObject
    {
        public ПричиныИзмененияСостояния(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПриемНаРаботу => GetProperty<EnumItemBase>("ПриемНаРаботу");
        public EnumItemBase Перемещение => GetProperty<EnumItemBase>("Перемещение");
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>("Увольнение");
    }
}

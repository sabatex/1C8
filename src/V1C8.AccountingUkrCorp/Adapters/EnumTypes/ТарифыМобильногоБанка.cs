using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТарифыМобильногоБанка:V1C8COMObject
    {
        public ТарифыМобильногоБанка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Экономный => GetProperty<EnumItemBase>("Экономный");
        public EnumItemBase Полный => GetProperty<EnumItemBase>("Полный");
    }
}

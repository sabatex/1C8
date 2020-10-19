using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТарифыМобильногоБанка:V1C8COMObject
    {
        public ТарифыМобильногоБанка(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Экономный => GetProperty<EnumItemBase>();
        public EnumItemBase Полный => GetProperty<EnumItemBase>();
    }
}

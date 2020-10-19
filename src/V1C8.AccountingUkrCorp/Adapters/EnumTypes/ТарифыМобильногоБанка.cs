using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТарифыМобильногоБанка:EnumBase
    {
        public ТарифыМобильногоБанка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Экономный => GetProperty<EnumItem>("Экономный");
        public EnumItem Полный => GetProperty<EnumItem>("Полный");
    }
}

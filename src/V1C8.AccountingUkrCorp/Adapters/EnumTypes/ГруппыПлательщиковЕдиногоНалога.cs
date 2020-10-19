using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыПлательщиковЕдиногоНалога:EnumBase
    {
        public ГруппыПлательщиковЕдиногоНалога(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПерваяГруппа => GetProperty<EnumItem>("ПерваяГруппа");
        public EnumItem ВтораяГруппа => GetProperty<EnumItem>("ВтораяГруппа");
        public EnumItem ТретьяГруппа => GetProperty<EnumItem>("ТретьяГруппа");
        public EnumItem ЧетвертаяГруппа => GetProperty<EnumItem>("ЧетвертаяГруппа");
        public EnumItem ПятаяГруппа => GetProperty<EnumItem>("ПятаяГруппа");
        public EnumItem ШестаяГруппа => GetProperty<EnumItem>("ШестаяГруппа");
    }
}

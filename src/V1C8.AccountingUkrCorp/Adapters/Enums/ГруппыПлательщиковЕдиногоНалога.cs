using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ГруппыПлательщиковЕдиногоНалога:V1C8COMObject
    {
        public ГруппыПлательщиковЕдиногоНалога(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПерваяГруппа => GetProperty<EnumItemBase>();
        public EnumItemBase ВтораяГруппа => GetProperty<EnumItemBase>();
        public EnumItemBase ТретьяГруппа => GetProperty<EnumItemBase>();
        public EnumItemBase ЧетвертаяГруппа => GetProperty<EnumItemBase>();
        public EnumItemBase ПятаяГруппа => GetProperty<EnumItemBase>();
        public EnumItemBase ШестаяГруппа => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыПубликацииДополнительныхОтчетовИОбработок:V1C8COMObject
    {
        public ВариантыПубликацииДополнительныхОтчетовИОбработок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Используется => GetProperty<EnumItemBase>();
        public EnumItemBase РежимОтладки => GetProperty<EnumItemBase>();
        public EnumItemBase Отключена => GetProperty<EnumItemBase>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыОбластейДанных:V1C8COMObject
    {
        public СтатусыОбластейДанных(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Новая => GetProperty<EnumItemBase>();
        public EnumItemBase Используется => GetProperty<EnumItemBase>();
        public EnumItemBase КУдалению => GetProperty<EnumItemBase>();
        public EnumItemBase Удалена => GetProperty<EnumItemBase>();
        public EnumItemBase ИмпортИзФайла => GetProperty<EnumItemBase>();
    }
}

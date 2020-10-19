using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыОбластейДанных:V1C8COMObject
    {
        public СтатусыОбластейДанных(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Новая => GetProperty<EnumItemBase>("Новая");
        public EnumItemBase Используется => GetProperty<EnumItemBase>("Используется");
        public EnumItemBase КУдалению => GetProperty<EnumItemBase>("КУдалению");
        public EnumItemBase Удалена => GetProperty<EnumItemBase>("Удалена");
        public EnumItemBase ИмпортИзФайла => GetProperty<EnumItemBase>("ИмпортИзФайла");
    }
}

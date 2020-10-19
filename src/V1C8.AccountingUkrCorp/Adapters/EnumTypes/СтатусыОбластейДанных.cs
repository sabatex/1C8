using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыОбластейДанных:EnumBase
    {
        public СтатусыОбластейДанных(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Новая => GetProperty<EnumItem>("Новая");
        public EnumItem Используется => GetProperty<EnumItem>("Используется");
        public EnumItem КУдалению => GetProperty<EnumItem>("КУдалению");
        public EnumItem Удалена => GetProperty<EnumItem>("Удалена");
        public EnumItem ИмпортИзФайла => GetProperty<EnumItem>("ИмпортИзФайла");
    }
}

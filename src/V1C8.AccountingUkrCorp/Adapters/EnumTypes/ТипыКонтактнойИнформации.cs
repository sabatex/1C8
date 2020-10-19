using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыКонтактнойИнформации:EnumBase
    {
        public ТипыКонтактнойИнформации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Адрес => GetProperty<EnumItem>("Адрес");
        public EnumItem Телефон => GetProperty<EnumItem>("Телефон");
        public EnumItem АдресЭлектроннойПочты => GetProperty<EnumItem>("АдресЭлектроннойПочты");
        public EnumItem Skype => GetProperty<EnumItem>("Skype");
        public EnumItem ВебСтраница => GetProperty<EnumItem>("ВебСтраница");
        public EnumItem Факс => GetProperty<EnumItem>("Факс");
        public EnumItem Другое => GetProperty<EnumItem>("Другое");
    }
}

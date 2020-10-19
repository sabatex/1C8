using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыКонтактнойИнформации:V1C8COMObject
    {
        public ТипыКонтактнойИнформации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Адрес => GetProperty<EnumItemBase>("Адрес");
        public EnumItemBase Телефон => GetProperty<EnumItemBase>("Телефон");
        public EnumItemBase АдресЭлектроннойПочты => GetProperty<EnumItemBase>("АдресЭлектроннойПочты");
        public EnumItemBase Skype => GetProperty<EnumItemBase>("Skype");
        public EnumItemBase ВебСтраница => GetProperty<EnumItemBase>("ВебСтраница");
        public EnumItemBase Факс => GetProperty<EnumItemBase>("Факс");
        public EnumItemBase Другое => GetProperty<EnumItemBase>("Другое");
    }
}

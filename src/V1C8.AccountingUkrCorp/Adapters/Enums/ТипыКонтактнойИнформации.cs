using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыКонтактнойИнформации:V1C8COMObject
    {
        public ТипыКонтактнойИнформации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Адрес => GetProperty<EnumItemBase>();
        public EnumItemBase Телефон => GetProperty<EnumItemBase>();
        public EnumItemBase АдресЭлектроннойПочты => GetProperty<EnumItemBase>();
        public EnumItemBase Skype => GetProperty<EnumItemBase>();
        public EnumItemBase ВебСтраница => GetProperty<EnumItemBase>();
        public EnumItemBase Факс => GetProperty<EnumItemBase>();
        public EnumItemBase Другое => GetProperty<EnumItemBase>();
    }
}

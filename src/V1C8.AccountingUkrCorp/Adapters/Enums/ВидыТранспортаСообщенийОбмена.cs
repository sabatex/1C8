using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыТранспортаСообщенийОбмена:V1C8COMObject
    {
        public ВидыТранспортаСообщенийОбмена(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase EMAIL => GetProperty<EnumItemBase>();
        public EnumItemBase FILE => GetProperty<EnumItemBase>();
        public EnumItemBase FTP => GetProperty<EnumItemBase>();
        public EnumItemBase WS => GetProperty<EnumItemBase>();
        public EnumItemBase COM => GetProperty<EnumItemBase>();
        public EnumItemBase WSПассивныйРежим => GetProperty<EnumItemBase>();
    }
}

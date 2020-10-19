using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТранспортаСообщенийОбмена:V1C8COMObject
    {
        public ВидыТранспортаСообщенийОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase EMAIL => GetProperty<EnumItemBase>("EMAIL");
        public EnumItemBase FILE => GetProperty<EnumItemBase>("FILE");
        public EnumItemBase FTP => GetProperty<EnumItemBase>("FTP");
        public EnumItemBase WS => GetProperty<EnumItemBase>("WS");
        public EnumItemBase COM => GetProperty<EnumItemBase>("COM");
        public EnumItemBase WSПассивныйРежим => GetProperty<EnumItemBase>("WSПассивныйРежим");
    }
}

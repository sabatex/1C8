using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТранспортаСообщенийОбмена:EnumBase
    {
        public ВидыТранспортаСообщенийОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem EMAIL => GetProperty<EnumItem>("EMAIL");
        public EnumItem FILE => GetProperty<EnumItem>("FILE");
        public EnumItem FTP => GetProperty<EnumItem>("FTP");
        public EnumItem WS => GetProperty<EnumItem>("WS");
        public EnumItem COM => GetProperty<EnumItem>("COM");
        public EnumItem WSПассивныйРежим => GetProperty<EnumItem>("WSПассивныйРежим");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодировкаФайловОбменаПоЗарплатномуПроекту:EnumBase
    {
        public КодировкаФайловОбменаПоЗарплатномуПроекту(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem UTF8 => GetProperty<EnumItem>("UTF8");
        public EnumItem Windows1251 => GetProperty<EnumItem>("Windows1251");
    }
}

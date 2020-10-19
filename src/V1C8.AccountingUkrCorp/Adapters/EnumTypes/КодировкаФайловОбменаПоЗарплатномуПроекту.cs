using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодировкаФайловОбменаПоЗарплатномуПроекту:V1C8COMObject
    {
        public КодировкаФайловОбменаПоЗарплатномуПроекту(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase UTF8 => GetProperty<EnumItemBase>("UTF8");
        public EnumItemBase Windows1251 => GetProperty<EnumItemBase>("Windows1251");
    }
}

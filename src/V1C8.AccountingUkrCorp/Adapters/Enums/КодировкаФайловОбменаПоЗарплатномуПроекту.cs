using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КодировкаФайловОбменаПоЗарплатномуПроекту:V1C8COMObject
    {
        public КодировкаФайловОбменаПоЗарплатномуПроекту(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase UTF8 => GetProperty<EnumItemBase>();
        public EnumItemBase Windows1251 => GetProperty<EnumItemBase>();
    }
}

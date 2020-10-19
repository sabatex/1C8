using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПравилДляОбменаДанными:V1C8COMObject
    {
        public ВидыПравилДляОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПравилаКонвертацииОбъектов => GetProperty<EnumItemBase>("ПравилаКонвертацииОбъектов");
        public EnumItemBase ПравилаРегистрацииОбъектов => GetProperty<EnumItemBase>("ПравилаРегистрацииОбъектов");
    }
}

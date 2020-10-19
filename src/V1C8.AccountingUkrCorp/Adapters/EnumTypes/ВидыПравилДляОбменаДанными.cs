using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПравилДляОбменаДанными:EnumBase
    {
        public ВидыПравилДляОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПравилаКонвертацииОбъектов => GetProperty<EnumItem>("ПравилаКонвертацииОбъектов");
        public EnumItem ПравилаРегистрацииОбъектов => GetProperty<EnumItem>("ПравилаРегистрацииОбъектов");
    }
}

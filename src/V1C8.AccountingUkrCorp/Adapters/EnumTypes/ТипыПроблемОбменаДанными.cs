using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПроблемОбменаДанными:EnumBase
    {
        public ТипыПроблемОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НепроведенныйДокумент => GetProperty<EnumItem>("НепроведенныйДокумент");
        public EnumItem НезаполненныеРеквизиты => GetProperty<EnumItem>("НезаполненныеРеквизиты");
    }
}

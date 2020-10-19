using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПроблемОбменаДанными:V1C8COMObject
    {
        public ТипыПроблемОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НепроведенныйДокумент => GetProperty<EnumItemBase>("НепроведенныйДокумент");
        public EnumItemBase НезаполненныеРеквизиты => GetProperty<EnumItemBase>("НезаполненныеРеквизиты");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВедениеВзаиморасчетовПоДоговорам:EnumBase
    {
        public ВедениеВзаиморасчетовПоДоговорам(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоДоговоруВЦелом => GetProperty<EnumItem>("ПоДоговоруВЦелом");
        public EnumItem ПоРасчетнымДокументам => GetProperty<EnumItem>("ПоРасчетнымДокументам");
    }
}

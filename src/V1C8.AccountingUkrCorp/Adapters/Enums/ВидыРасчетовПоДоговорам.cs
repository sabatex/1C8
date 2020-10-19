using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыРасчетовПоДоговорам:V1C8COMObject
    {
        public ВидыРасчетовПоДоговорам(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасчетыВВалютеРегламентированногоУчета => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыВИностраннойВалюте => GetProperty<EnumItemBase>();
    }
}

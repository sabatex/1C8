using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРасчетовПоДоговорам:V1C8COMObject
    {
        public ВидыРасчетовПоДоговорам(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасчетыВВалютеРегламентированногоУчета => GetProperty<EnumItemBase>("РасчетыВВалютеРегламентированногоУчета");
        public EnumItemBase РасчетыВИностраннойВалюте => GetProperty<EnumItemBase>("РасчетыВИностраннойВалюте");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРасчетовПоСредствамФСС:V1C8COMObject
    {
        public ВидыРасчетовПоСредствамФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасходыПоСтрахованию => GetProperty<EnumItemBase>("РасходыПоСтрахованию");
        public EnumItemBase ПолученоИзФонда => GetProperty<EnumItemBase>("ПолученоИзФонда");
        public EnumItemBase НеПринято => GetProperty<EnumItemBase>("НеПринято");
    }
}

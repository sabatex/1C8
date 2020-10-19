using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРасчетовПоСредствамФСС:EnumBase
    {
        public ВидыРасчетовПоСредствамФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem РасходыПоСтрахованию => GetProperty<EnumItem>("РасходыПоСтрахованию");
        public EnumItem ПолученоИзФонда => GetProperty<EnumItem>("ПолученоИзФонда");
        public EnumItem НеПринято => GetProperty<EnumItem>("НеПринято");
    }
}

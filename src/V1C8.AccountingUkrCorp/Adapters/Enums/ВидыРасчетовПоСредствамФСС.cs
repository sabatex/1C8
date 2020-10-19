using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыРасчетовПоСредствамФСС:V1C8COMObject
    {
        public ВидыРасчетовПоСредствамФСС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасходыПоСтрахованию => GetProperty<EnumItemBase>();
        public EnumItemBase ПолученоИзФонда => GetProperty<EnumItemBase>();
        public EnumItemBase НеПринято => GetProperty<EnumItemBase>();
    }
}
